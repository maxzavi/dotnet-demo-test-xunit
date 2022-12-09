public class CalcTest
{
    [Fact]
    public void testAdd(){
        int result = Calc.add(1,2);
        Assert.Equal(3, result);
    }
    [Fact]
    public void testAddZero(){
        int myVal = 5;
        int result = Calc.add(0,myVal);
        Assert.Equal(myVal, result);
    }
    [Fact]
    public void TestSubstraction()
    {
        int result = Calc.substr(3,1);
        Assert.Equal(2, result);
    }
    [Fact]
    public void TestSubstractionSelf()
    {
        // Given
        int x=5;
        // When
        int result = Calc.substr(x,x);
        // Then
        Assert.Equal(0, result);
    }
}