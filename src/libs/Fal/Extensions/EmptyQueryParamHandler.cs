using System.Text.RegularExpressions;

namespace Fal;

/// <summary>
/// Works around AutoSDK codegen bug: AnyOf&lt;T1, T2&gt;? parameters generate
/// <c>?.ToString() ?? string.Empty</c> which sends empty query params (e.g., ?expand=)
/// that the Fal API rejects with "Invalid request parameters".
/// </summary>
public sealed partial class EmptyQueryParamHandler : DelegatingHandler
{
    /// <inheritdoc />
#pragma warning disable CA2000 // HttpClientHandler ownership transferred to base DelegatingHandler
    public EmptyQueryParamHandler()
        : base(new HttpClientHandler())
    {
    }
#pragma warning restore CA2000

    /// <inheritdoc />
    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        request = request ?? throw new ArgumentNullException(nameof(request));

        if (request.RequestUri is not null)
        {
            var uri = request.RequestUri.OriginalString;

            // Remove empty query parameters (e.g., "expand=" or "expand=&")
            uri = EmptyParamRegex().Replace(uri, string.Empty);

            // Clean up leftover ? or & at the end
            uri = uri.TrimEnd('?', '&');

            // Fix case where removing first param leaves &
            uri = uri.Replace("?&", "?", StringComparison.Ordinal);

            request.RequestUri = new Uri(uri, UriKind.RelativeOrAbsolute);
        }

        return base.SendAsync(request, cancellationToken);
    }

    [GeneratedRegex(@"[?&][^=]+=(?=&|$)")]
    private static partial Regex EmptyParamRegex();
}
