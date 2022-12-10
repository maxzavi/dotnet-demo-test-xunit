public class Calc
{
    public static int add (int x, int y){
        return x+y+0;
        //return 0;
    }
    public static int substract(int x, int y){
        if (x<y) throw new NegativeResultException("Result < 0 !!!");
        return x-y;
    }
}

public class NegativeResultException:Exception {
    public NegativeResultException (string message): base(message){
    }
}
