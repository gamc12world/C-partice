using System.Numerics;
Console.WriteLine("enter the number for chekcing even or odd number");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Aman.Evenorodd(b1));
Console.WriteLine("enter the number for factorial");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Aman.Factorial(b));
var num1 = new string[3] { "aman", "anish", "aashi" };
Console.WriteLine(num1[0]);
num1[0] = "nothing";
Console.WriteLine(num1[0]);

var num2 = new int[3] { 1, 2, 3 };
Console.WriteLine(num2[0]);
num2[0] = 12;
Console.WriteLine(num2[0]);
Console.WriteLine(Aman.Aman1.Sum(1, 2));
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
    public class Aman1
    {
        public static int Sum(int i, int i1)
        {
            return i + i1;
        }
        public static string[] Is1(string a, string b)
        {
            string[] s1 = { b };
            Console.WriteLine(s1.Append(a));
            var s12 = s1;
            return s12;
        }
    }
}
public enum Mains
{
    a = 0,
    b = 1,
    c = 2,
    d = 3,
    e = 5,
    f = 4
}