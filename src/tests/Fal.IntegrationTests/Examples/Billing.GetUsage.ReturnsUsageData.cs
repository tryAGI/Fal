/*
order: 50
title: Billing Get Usage Returns Usage Data
slug: billing-get-usage-returns-usage-data
*/

namespace Fal.IntegrationTests;

public partial class Tests
{
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
