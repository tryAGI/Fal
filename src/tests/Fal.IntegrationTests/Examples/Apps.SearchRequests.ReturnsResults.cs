/*
order: 30
title: Apps Search Requests Returns Results
slug: apps-search-requests-returns-results
*/

namespace Fal.IntegrationTests;

public partial class Tests
{
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
