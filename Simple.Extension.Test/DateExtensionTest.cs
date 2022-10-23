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
    public void IsBetweenTestSutLowerOk()
    {
        var rangeBeggin = new DateTime(2022, 10, 03);
        var rangeEnd = new DateTime(2023, 10, 10);
        var sut = new DateTime(2021, 10, 01);
        
        Assert.IsFalse(sut.IsBetween(rangeBeggin, rangeEnd), "This test must return false because sut is < than rangebeggin");
    }
    
    [Test]
    public void IsBetweenTestSutSupOk()
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
    
    [Test]
    public void FirstAndLastDayOfTheWeekOk()
    {
        var sut = new DateTime(2022, 10, 23);
        var fistDayOfTheWeek = sut.GetFirstDayOfWeek();
        var lastDayOfTheWeek = sut.GetLastDayOfWeek();
        
        Assert.IsTrue(fistDayOfTheWeek.Ticks == new DateTime(2022, 10, 17).Ticks);
        Assert.IsTrue(lastDayOfTheWeek.Ticks == new DateTime(2022, 10, 23).Ticks);
    }
    
    
}
