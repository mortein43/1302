using System;
using System.Reflection;
using static System.Console;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class CoderAttribute : Attribute
{
    string name = "Василiу Андрiй";
    string group = "ПВ 222";
    public CoderAttribute() { }
    public override string ToString()
    {
        return $"Розробив: {name}.\nГрупа: {group}.\n";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        CoderAttribute cod = new CoderAttribute();
        WriteLine(cod.ToString());
        Console.WriteLine("Запустiть main.exe з трьома параметрами.");
        Console.WriteLine("Перших два параметри це числа, третiй дiя яку потрiбно виконати над цими числами.");
        Console.WriteLine("Приклади введення дiї:");
        Console.WriteLine("Для додавання - додати.");
        Console.WriteLine("Для вiднiмання - вiдняти.");
        Console.WriteLine("Для множення - помножити.");
        Console.WriteLine("Для дiлення - подiлити.");
        if (args.Length != 3)
        {
            Console.WriteLine("Ви неккоректно ввели параметри.\nСпробуйте знову.");
        }
        else
        {
            double a = double.Parse(args[0]);
            double b = double.Parse(args[1]);
            if (args[2] == "додати")
            {
                double c = a + b;
                Console.WriteLine($"{a}+{b}={c}");
            }
            else if (args[2] == "відняти")
            {
                double c = a - b;
                Console.WriteLine($"{a}-{b}={c}");
            }
            else if (args[2] == "помножити")
            {
                double c = a * b;
                Console.WriteLine($"{a}*{b}={c}");
            }
            else if (args[2] == "поділити")
            {
                if (b == 0)
                {
                    Console.WriteLine("На нуль ділити не можна.");
                }
                else
                {
                    double c = a / b;
                    Console.WriteLine($"{a}/{b}={c}");
                }
            }
        }
    }
}