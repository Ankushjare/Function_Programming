using System;
public class Exercise15
{
    public static void Main()
    {
        /*int i, f = 1, num;

        Console.Write("\n\n");
        Console.Write("Calculate the factorial of a given number:\n");
        Console.Write("--------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the number : ");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= num; i--)
            f = f * i;


        Console.Write("The Factorial of {0} is: {1}\n", i, f);*/
        int i, j, num, isPrime;
        Console.Write("Input the number : ");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 2; i <= num; i++)
        {
            if (num % i == 0)
            {
                isPrime = 1;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                }
                if (isPrime == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}