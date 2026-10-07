"""Ask the Shop with actions: the Python agent side of AgentGate.

The agent never holds a long-lived or all-powerful credential. For each conversation it exchanges
the customer's token for a short-lived, narrower agent token and sends only that token to the
tool gateway, which decides what is allowed.
"""

__version__ = "0.1.0"
