namespace Fal.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Billing_GetAccountBilling_ReturnsUsername()
    {
        var client = GetAuthorizedApi();

        var response = await client.Account.GetAccountBillingAsync();

        response.Should().NotBeNull();
        response.Username.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Billing_GetAccountBilling_WithCreditsExpand()
    {
        var client = GetAuthorizedApi();

        var response = await client.Account.GetAccountBillingAsync(
            expand: "credits");

        response.Should().NotBeNull();
        response.Username.Should().NotBeNullOrEmpty();
        response.Credits.Should().NotBeNull();
        response.Credits!.Currency.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Billing_GetUsage_ReturnsUsageData()
    {
        var client = GetAuthorizedApi();

        var response = await client.Models.GetUsageAsync(
            limit: 5);

        response.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Billing_GetBillingEvents_ReturnsBillingEvents()
    {
        var client = GetAuthorizedApi();

        var response = await client.Models.GetBillingEventsAsync(
            limit: 5);

        response.Should().NotBeNull();
        response.BillingEvents.Should().NotBeNull();
    }
}
