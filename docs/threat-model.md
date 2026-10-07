# Threat model

Status: template. Filled in during week 4 of the roadmap.

Method: STRIDE (spoofing, tampering, repudiation, information disclosure, denial of service, elevation of privilege) applied to each component and trust boundary in [architecture.md](architecture.md). Every threat maps to a mitigation and to the named test that proves the mitigation works.

## Assets

- Customer order data and addresses
- Refund actions (money leaving the shop)
- Token signing keys
- The audit log

## Trust boundaries

- Customer browser to authorization server
- Customer to agent (untrusted chat input)
- Help articles and order notes to agent (untrusted retrieved content)
- Agent to gateway (the model's tool calls are untrusted)
- Gateway to shop data and audit log

## Threats

The first row shows the format.

| ID | Component | STRIDE | Threat | Mitigation | Test |
| --- | --- | --- | --- | --- | --- |
| T1 | Gateway | Spoofing | Forged access token | Verify the signature against the authorization server's JWKS; reject `alg: none` and HS256 | `Rejects_token_with_alg_none` |
| T2 | | | | | |
