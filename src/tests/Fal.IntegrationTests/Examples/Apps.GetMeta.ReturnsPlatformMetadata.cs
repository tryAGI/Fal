/*
order: 10
title: Apps Get Meta Returns Platform Metadata
slug: apps-get-meta-returns-platform-metadata
*/

namespace Fal.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Apps_GetMeta_ReturnsPlatformMetadata()
    {
        var client = GetAuthorizedApi();

        var response = await client.Meta.GetMetaAsync();

        response.Should().NotBeNull();
        response.WebhookIpRanges.Should().NotBeNull();
        response.WebhookIpRanges.Should().NotBeEmpty();
    }
}
