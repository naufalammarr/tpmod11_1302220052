using System;
using AljabarLibraries;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Akar Persamaan Kuadrat: {0}", FormatArray(akar));

            double[] hasilKuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil Kuadrat: {0}", FormatArray(hasilKuadrat));
        }

        static string FormatArray(double[] array)
        {
            return "{" + string.Join(", ", array) + "}";
        }
    }
}