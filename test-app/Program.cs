// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x=1;
int y=4;
int resultAdd= Calc.add(x,y);
Console.WriteLine($"Calc add: x=>{x}+ y=>{y}= {resultAdd}");
try
{
    int resultSubtr= Calc.substr(x,y);
    Console.WriteLine($"Calc substr: x=>{x}- y=>{y}= {resultSubtr}");
}
catch (NegativeResultException ex)
{
    System.Console.WriteLine($"Error in substraction method: {ex.Message}");
}
