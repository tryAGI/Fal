namespace Fal.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Apps_GetPricing_ReturnsPriceForEndpoint()
    {
        var client = GetAuthorizedApi();

        var response = await client.Models.GetPricingAsync(
            endpointId: "fal-ai/flux/dev");

        response.Should().NotBeNull();
        response.Prices.Should().NotBeNull();
        response.Prices.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Apps_GetMeta_ReturnsPlatformMetadata()
    {
        var client = GetAuthorizedApi();

        var response = await client.Meta.GetMetaAsync();

        response.Should().NotBeNull();
        response.WebhookIpRanges.Should().NotBeNull();
        response.WebhookIpRanges.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Apps_SearchRequests_ReturnsResults()
    {
        var client = GetAuthorizedApi();

        var response = await client.Models.SearchRequestsAsync(
            limit: 5);

        response.Should().NotBeNull();
        response.Results.Should().NotBeNull();
    }
}
