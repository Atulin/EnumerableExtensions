namespace EnumerableExtensions.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_Pad()
    {
        var initial = Enumerable.Range(0, 3);
        var padded = initial.Pad(3, -1);
        Assert.Equal(padded, [0, 1, 2, -1, -1, -1]);
    }
    
    [Fact]
    public void Test_PadLeft()
    {
        var initial = Enumerable.Range(0, 3);
        var padded = initial.PadLeft(3, -1);
        Assert.Equal(padded, [-1, -1, -1, 0, 1, 2]);
    }

    [Fact]
    public void Test_PadTo()
    {
        var initial = Enumerable.Range(0, 3);
        var padded = initial.PadTo(5, -1);
        Assert.Equal(padded, [0, 1, 2, -1, -1]);
    }
}