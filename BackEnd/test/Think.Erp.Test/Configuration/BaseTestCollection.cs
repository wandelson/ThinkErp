using Xunit;

namespace Think.Erp.Api.IntegrationTests.Configuration
{
    [CollectionDefinition("Base collection")]
    public abstract class BaseTestCollection : ICollectionFixture<BaseTestFixture>
    {
    }
}