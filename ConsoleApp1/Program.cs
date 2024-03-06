//Ввести строки з файлу, записати в список. Вивести строки у файл у зворотному порядку.
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> text = new List<string>(File.ReadAllLines("D:\\ДЗ\\Прога\\sem2\\lab1\\story.txt"));
        ReversedText(text, "D:\\ДЗ\\Прога\\sem2\\lab1\\result.txt");
        Console.WriteLine("Завдання виконано!");
        Console.ReadKey();

    }
    static void ReversedText(List<string> text, string path)
    {
        try
        {
            text.Reverse();
            File.WriteAllLines(path, text.ToArray());

        }
        catch (Exception ex)
        {
            Console.WriteLine("ПОМИЛКА!!!");
        }
    }
}


