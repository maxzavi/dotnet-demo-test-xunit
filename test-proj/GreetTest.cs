public class GreetTest
{
    [Fact]
    public void Greeting_GivenName_ReturnNameAndGreet (){
        //Arrange
        string name= "Jhon";
        string expected= "Hi Jhon!!";
        //Act
        string result = Greet.Greeting(name);
        //Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Greeting_GivenName_ReturnIgnoreCapital(){
        //Arrange
        string name= "Jhon";
        string expected= "hi jhon!!";
        //Act
        string result = Greet.Greeting(name);
        //Assert
        Assert.Equal(expected, result, ignoreCase:true);
    }
    [Fact]
    public void Greeting_GivenNullArgs_ThrowArgumentNullException(){
        //Arrange
        string name= null;
        //Act
        Action action = ()=>Greet.Greeting(name);
        //Assert
        Assert.Throws<ArgumentNullException> (action);
    }
    [Fact]
    public void Greeting_GivenEmptyArgs_ThrowArgumentNullException(){
        //Arrange
        string name= "";
        //Act
        Action action = ()=>Greet.Greeting(name);
        //Assert
        Assert.Throws<ArgumentNullException> (action);
    }
}