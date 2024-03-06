//task3
using System;
using System.Threading.Channels;
class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int> { 1, 2, 3, 4, 5, 17, 20, -4, -6, -8, -3, 45, -100 };
        var result = num.Where(n => n < 0 && n % 2 == 0)
                     .OrderByDescending(n => n);


        Console.WriteLine("Результат:");
        foreach (int n in result)
        { Console.WriteLine(n); }
    }
}



