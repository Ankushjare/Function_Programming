using System;
public class Exercise8
{
    public static void Main()
    {
        int  n;
        Console.Write("Display the power of 2 at nth location:\n");

        Console.Write("Input number of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("the 2 table");
        /*for (i = 0; i <= n; i++)
        {

            Console.Write("{0}\n", i  2);
        }*/
        int value = 2;
        for (int power = 0; power <= n; power++)
            Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} ");

       

    }
}