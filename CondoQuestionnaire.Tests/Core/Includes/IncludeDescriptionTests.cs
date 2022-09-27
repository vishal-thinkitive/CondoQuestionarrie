using CondoQuestionnaire.Core.Includes;
using NUnit.Framework;

namespace CondoQuestionnaire.Tests.Core.Includes;

public class IncludeDescriptionTests
{
    [Test]
    public void TrueWhenExpectPropertiesAreIncludedByName()
    {
        var descriptor = new IncludeDescription<TestClass>();

        descriptor.Include(x => x.Prop1);
        
        Assert.True(descriptor.Contains(nameof(TestClass.Prop1)));
    }
    
    [Test]
    public void TrueWhenExpectPropertiesAreIncludedByLambda()
    {
        var descriptor = new IncludeDescription<TestClass>();

        descriptor.Include(x => x.Prop1);
        Assert.True(descriptor.IncludesField(x => x.Prop1));
    }
    
    [Test]
    public void FalseWhenDoNotExistPropertiesAreIncludedByLambda()
    {
        var descriptor = new IncludeDescription<TestClass>();

        descriptor.Include(x => x.Prop1);
        Assert.False(descriptor.IncludesField(x => x.Prop3));
    }

    private sealed class TestClass
    {
        public string Prop1;
        public string Prop2;
        public string Prop3;
        public string Prop4;
    }
}