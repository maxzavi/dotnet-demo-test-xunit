public class CalcTest
{
    [Fact]
    public void add_GivenTwoValues_ReturnValue(){
        //Arrange
        var expected=3;
        //Act
        int result = Calc.add(1,2);
        //Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void add_AddZero_ReturnSelf(){
        //Arrange
        int myVal = 5;
        //Act
        int result = Calc.add(0,myVal);
        //Assert
        Assert.Equal(myVal, result);
    }
    [Fact]
    public void substract_GivenTwoValues_ReturnValue()
    {
        //Arrange
        var expected = 2;
        //Act
        int result = Calc.substract(3,1);
        //Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void substract_GivenSameValues_ReturnZero()
    {
        // Arrange
        int x=5;
        int expected=0;
        // Act
        int result = Calc.substract(x,x);
        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void substract_GivenTwoValuesIncorrect_ThrowNegativeValue()
    {
        // Arrange
        int x = 1;
        int y = 2;
        // Act
        Action action = ()=> Calc.substract(x,y);
        // Assert
        Assert.Throws<NegativeResultException>(action);
    }
    [Fact]
    public void addDouble_GivenTwoDoubles_ReturnDouble (){
        //Arrange
        double x= 1.54;
        double y =2.32;
        double expected=3.9;
        //Act
        double result = Calc.addDouble (x,y);
        //Assert
        Assert.Equal(expected,result,1);
    }
    [Fact]
    public void GetFirtsPairs_NotIncludeOdd()
    {
        // Arrange
        int expected=1;
        // Act
        var listPairs = Calc.GetFirtsPairs;
        // TAssert
        Assert.All(listPairs, n => Assert.NotEqual(expected, n));
    }
    [Fact]
    public void GetFirtsPairs_Include8()
    {
        // Arrange
        int expected=8;
        // Act
        var listPairs = Calc.GetFirtsPairs;
        // TAssert
        Assert.Contains(expected, listPairs);
    }
    [Fact]
    public void GetFirtsPairs_NotInclude5()
    {
        // Arrange
        int expected=5;
        // Act
        var listPairs = Calc.GetFirtsPairs;
        // TAssert
        Assert.DoesNotContain(expected, listPairs);
    }
    [Fact]
    public void GetFirtsPairs_ValuesInRange()
    {
        // Arrange
        int minValue=0;
        int maxValue=12;
        // Act
        var listPairs = Calc.GetFirtsPairs;
        // Assert
        Assert.All(listPairs, n => Assert.InRange(n,minValue,maxValue));
    }
}