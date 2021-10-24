using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        int a = 22, b = 23;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a + b;       
        b = a - b; 
        a = a - b; 
        Console.Write("After swap a= " + a + " b= " + b);
    }
}