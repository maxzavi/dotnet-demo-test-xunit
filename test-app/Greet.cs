public class Greet
{
    public static string Greeting(string name){
        if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
        return $"Hi {name}!!";
    }
}