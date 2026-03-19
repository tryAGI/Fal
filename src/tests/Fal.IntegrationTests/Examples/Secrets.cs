/*
order: 60
title: Secrets
slug: secrets
*/

namespace Fal.IntegrationTests;

public partial class Tests
{
    /// <summary>
    /// Requires an ADMIN API key. Skips if current key lacks permissions.
    /// </summary>
    [TestMethod]
    public async Task Secrets_ListApiKeys_ReturnsKeys()
    {
        var client = GetAuthorizedApi();

        try
        {
            var response = await client.Keys.ListApiKeysAsync(limit: 10);

            response.Should().NotBeNull();
            response.Keys.Should().NotBeNull();
        }
        catch (ApiException ex) when (ex.Message.Contains("Admin API key"))
        {
            Assert.Inconclusive("Requires ADMIN API key.");
        }
    }
}
