/*
order: 40
title: Billing Get Account Billing Returns Username
slug: billing-get-account-billing-returns-username
*/

namespace Fal.IntegrationTests;

public partial class Tests
{
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
}
