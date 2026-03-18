namespace Fal.IntegrationTests;

public partial class Tests
{
    /// <summary>
    /// Requires an ADMIN API key. Skips if current key lacks permissions.
    /// </summary>
    [TestMethod]
    public async Task Billing_GetAccountBilling_ReturnsUsername()
    {
        var client = GetAuthorizedApi();

        try
        {
            var response = await client.Account.GetAccountBillingAsync();

            response.Should().NotBeNull();
            response.Username.Should().NotBeNullOrEmpty();
        }
        catch (ApiException ex) when (ex.Message.Contains("Admin API key"))
        {
            Assert.Inconclusive("Requires ADMIN API key.");
        }
    }

    /// <summary>
    /// Requires an ADMIN API key. Skips if current key lacks permissions.
    /// </summary>
    [TestMethod]
    public async Task Billing_GetUsage_ReturnsUsageData()
    {
        var client = GetAuthorizedApi();

        try
        {
            var response = await client.Models.GetUsageAsync(limit: 5);

            response.Should().NotBeNull();
        }
        catch (ApiException ex) when (ex.Message.Contains("Admin API key"))
        {
            Assert.Inconclusive("Requires ADMIN API key.");
        }
    }
}
