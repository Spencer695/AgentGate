import agentgate_agent


def test_package_imports_with_version():
    assert agentgate_agent.__version__ == "0.1.0"
