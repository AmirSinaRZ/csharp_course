using System;

class Program
{
    static void Main()
    {
        Console.Write("عدد اول را وارد کنید: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("عدد دوم را وارد کنید: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"جمع: {num1 + num2}");
        Console.WriteLine($"تفریق: {num1 - num2}");
        Console.WriteLine($"ضرب: {num1 * num2}");
        if (num2 != 0)
            Console.WriteLine($"تقسیم: {num1 / num2}");
        else
            Console.WriteLine("تقسیم بر صفر ممکن نیست.");
    }
}
