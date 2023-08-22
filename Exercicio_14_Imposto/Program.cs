using System.Globalization;
using System;
using System.Globalization;
using System.Drawing;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o salário do funcionário: \n");
        double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double Imposto = 0.0;

        if (Salario <= 2000.00)
        {
            Console.WriteLine("\nImposto = 0.00");
        }

        else if (Salario <= 3000.00)
        {
            Imposto = (Salario - 2000.00) * 0.18 + 1000.00 * 0.08;
        }

        else
        {
            Imposto = (Salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
        }

        if (Imposto == 0.00)
        {
            Console.WriteLine("\nIsento");
        }

        else
        {
            Console.WriteLine("\nR$ " + Imposto.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}