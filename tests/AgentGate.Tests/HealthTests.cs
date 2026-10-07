using System.Net;
using AgentGate.AuthServer;
using AgentGate.Gateway;
using Microsoft.AspNetCore.Mvc.Testing;

namespace AgentGate.Tests;

// Smoke tests that start each service in memory. The protocol tests from the roadmap
// (wrong PKCE verifier, reused code, expired token, wrong audience, alg "none") follow this pattern.
public class HealthTests
{
    [Fact]
    public async Task AuthServer_health_endpoint_returns_ok()
    {
        await using var factory = new WebApplicationFactory<AuthServerEntryPoint>();
        using var client = factory.CreateClient();

        var response = await client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Gateway_health_endpoint_returns_ok()
    {
        await using var factory = new WebApplicationFactory<GatewayEntryPoint>();
        using var client = factory.CreateClient();

        var response = await client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
