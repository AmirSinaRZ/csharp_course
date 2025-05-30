using System;

class Program
{
    static void Main()
    {
        Console.Write("لطفاً یک عدد وارد کنید: ");
        int num = int.Parse(Console.ReadLine());
        
        if (num % 2 == 0)
            Console.WriteLine("عدد زوج است.");
        else
            Console.WriteLine("عدد فرد است.");
    }
}
