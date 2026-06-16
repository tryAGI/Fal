namespace Fal;

internal sealed class FalAuthorizationHeaderHook : AutoSDKHook
{
    public override Task OnBeforeRequestAsync(AutoSDKHookContext context)
    {
        var authorization = context.Request?.Headers.Authorization;
        if (authorization is not null &&
            string.Equals(authorization.Scheme, "Bearer", StringComparison.Ordinal))
        {
            context.Request!.Headers.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Key", authorization.Parameter);
            AutoSDKHttpRequestOptions.StampAuthorizationOverride(context.Request);
        }

        return Task.CompletedTask;
    }
}

internal static class FalAuthorizationHeaderHookRegistration
{
    public static void Add(AutoSDKClientOptions options)
    {
        if (options.Hooks.Exists(static hook => hook is FalAuthorizationHeaderHook))
        {
            return;
        }

        options.Hooks.Add(new FalAuthorizationHeaderHook());
    }
}

public sealed partial class FalClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class AccountClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class AssetsClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class ComputeClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class KeysClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class MetaClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class ModelsClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class OrganizationClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class ServerlessClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class StorageClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}

public sealed partial class WorkflowsClient
{
    partial void Initialized(System.Net.Http.HttpClient client)
    {
        FalAuthorizationHeaderHookRegistration.Add(Options);
    }
}
