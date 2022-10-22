using NUnit.Framework;
using Simple.Extension.Date;

namespace Simple.Extension.Test;

public class DateExtensionTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsBetweenTestSutLower()
    {
        var rangeBeggin = new DateTime(2022, 10, 03);
        var rangeEnd = new DateTime(2023, 10, 10);
        var sut = new DateTime(2021, 10, 01);
        
        Assert.IsFalse(sut.IsBetween(rangeBeggin, rangeEnd), "This test must return false because sut is < than rangebeggin");
    }
    
    [Test]
    public void IsBetweenTestSutSup()
    {
        var rangeBeggin = new DateTime(2022, 10, 03);
        var rangeEnd = new DateTime(2023, 10, 10);
        var sut = new DateTime(2024, 10, 01);
        
        Assert.IsFalse(sut.IsBetween(rangeBeggin, rangeEnd), "This test must return false because sut is > than rangebeggin");
    }
    
    [Test]
    public void IsBetweenTestSutOk()
    {
        var rangeBeggin = new DateTime(2022, 10, 03);
        var rangeEnd = new DateTime(2023, 10, 10);
        var sut = new DateTime(2022, 12, 01);
        
        Assert.IsTrue(sut.IsBetween(rangeBeggin, rangeEnd), "This test must return true because sut is <> rangeBeggin and rangeEnd");
    }
    
}
