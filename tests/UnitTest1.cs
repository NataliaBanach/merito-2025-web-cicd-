namespace tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
}


public class UnitTest2
{
    [Fact]
    public void Test2_HelloWorld()
    {
        Assert.Equal("Hello world 1", "Hello world 1");
    }
}
