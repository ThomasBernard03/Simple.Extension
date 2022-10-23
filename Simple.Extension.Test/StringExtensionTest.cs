using NUnit.Framework;
using Simple.Extension.String;

namespace Simple.Extension.Test;

public class StringExtensionTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsNullOrEmptyOk()
    {
        var sot = "Test";
        
        Assert.IsTrue(sot.IsNotNullOrEmpty());
        Assert.IsFalse(sot.IsNullOrEmpty());
        Assert.IsTrue("".IsNullOrEmpty());
    }
}