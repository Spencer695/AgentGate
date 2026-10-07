// AgentGate authorization server (OAuth 2.1).
//
// Planned endpoints (see the roadmap in README.md):
//   GET  /authorize                                 authorization code flow with PKCE (S256 only)
//   POST /token                                     code exchange, refresh token rotation, token exchange (RFC 8693)
//   GET  /.well-known/jwks.json                     public signing keys
//   GET  /.well-known/oauth-authorization-server    server metadata (RFC 8414)

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok", service = "authserver" }));

app.Run();
