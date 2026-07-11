using Soenneker.Tests.HostedUnit;

namespace Soenneker.Monday.GraphQlClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MondayGraphQlClientTests : HostedUnitTest
{
    public MondayGraphQlClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
