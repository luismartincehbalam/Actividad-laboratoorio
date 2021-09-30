using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Functions.IntegrationsTest
{
    [CollectionDefinition(nameof(FunctionTestCollections))]
public  class FunctionTestCollections : ICollectionFixture<FunctionTestFixture>
    {
    }
}
