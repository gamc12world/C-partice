using System.Numerics;
Console.WriteLine("enter the number for chekcing even or odd number");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Aman.Evenorodd(b1));
Console.WriteLine("enter the number for factorial");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Aman.Factorial(b));
public class Aman
{
    public static int Evenorodd(int a)
    {
        for (int i = 0; i <= a; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"even number is {i} \n");
            }
            else
            {
                Console.WriteLine($"odd number is {i} \n");
            }
        }
        return a;
    }
    public static BigInteger Factorial(int a)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= a; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
}
public struct Rgb
{
    public int r;
    public int g;
    public int b;
}