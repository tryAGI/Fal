namespace Fal.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Apps_GetModels_ListsAvailableModels()
    {
        var client = GetAuthorizedApi();

        var response = await client.Models.GetModelsAsync(
            limit: 5);

        response.Should().NotBeNull();
        response.Models.Should().NotBeNull();
        response.Models.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Apps_GetModels_SearchByCategory()
    {
        var client = GetAuthorizedApi();

        var response = await client.Models.GetModelsAsync(
            limit: 5,
            category: "text-to-image");

        response.Should().NotBeNull();
        response.Models.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Apps_GetModels_FindByEndpointId()
    {
        var client = GetAuthorizedApi();

        var response = await client.Models.GetModelsAsync(
            endpointId: "fal-ai/flux/dev");

        response.Should().NotBeNull();
        response.Models.Should().NotBeNull();
        response.Models.Should().NotBeEmpty();
    }

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
    public async Task Apps_ListWorkflows_ReturnsWorkflows()
    {
        var client = GetAuthorizedApi();

        var response = await client.Workflows.ListWorkflowsAsync(
            limit: 5);

        response.Should().NotBeNull();
        response.Workflows.Should().NotBeNull();
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
