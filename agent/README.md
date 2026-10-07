# Agent

The Python side of AgentGate: [Ask the Shop](https://github.com/Spencer695/ask-the-shop), extended so it can take actions for a signed-in customer of Fernwood Supply.

Planned for week 3:

- Tool calling through the Claude API for `get_order`, `list_orders`, `refund_order`, and `update_address`
- Exchange the customer's token for a 2-minute agent token before any tool call
- Send only the agent token to the gateway, never the customer's token or an API key
- An insecure baseline mode (one all-powerful API key) used only by the red-team eval

Run the tests from this folder:

```bash
pip install -r requirements.txt
pytest
```
