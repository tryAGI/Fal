/*
order: 20
title: Apps Get Pricing Returns Price For Endpoint
slug: apps-get-pricing-returns-price-for-endpoint
*/

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
}
