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
}