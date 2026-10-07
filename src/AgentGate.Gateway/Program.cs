// AgentGate tool gateway (OAuth 2.1 resource server).
//
// Every tool call must pass, in order: token signature, issuer, audience, expiry and not-before,
// required scope, then the policy engine (roles plus ownership). Anything not allowed is denied,
// and every decision is appended to the audit log.
//
// Planned endpoints (see the roadmap in README.md):
//   POST /tools/get_order, /tools/list_orders, /tools/refund_order, /tools/update_address
//   GET  /.well-known/oauth-protected-resource      protected resource metadata (RFC 9728)

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok", service = "gateway" }));

app.Run();
