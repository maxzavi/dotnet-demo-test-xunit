public class Calc
{
    public static int add (int x, int y){
        return x+y+0;
        //return 0;
    }
    public static int substract(int x, int y){
        if (x<y) throw new NegativeResultException(1000,"Result < 0 !!!");
        return x-y;
    }
    public static double addDouble(double x, double y){
        return x+y;
    }

    public static List<int> GetFirtsPairs => new List<int>{0,2,4,6,8,10};
}

public class NegativeResultException:Exception {
    public int code {get;set;}
    public NegativeResultException (int code, string message): base(message){
        this.code=code;
    }
}
