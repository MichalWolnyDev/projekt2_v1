using System;
using System.Numerics;
using System.Diagnostics;

//  Projekt wykonali: Michał Wolny i Patryk Tomaszewski
namespace ConsoleApp1
{
    class Program
    {
        public static ulong ModuloCounterDecent, ModuloCounterExample;
        private static bool IsPrimeExample(BigInteger n)
        {
            ModuloCounterExample = 1;
            if (n < 2) return false;
            else if (n < 4) return true;
            else if (n % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i < n / 2; i += 2)
                {
                    ModuloCounterExample++;
                    if (n % i == 0) return false;
                }
            }

            return true;
        }
        private static bool IsPrimeExampleClear(BigInteger n)
        {
            if (n < 2) return false;
            else if (n < 4) return true;
            else if (n % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i < n / 2; i += 2)
                {
                    if (n % i == 0) return false;
                }
            }

            return true;
        }
        private static bool IsPrimeDecent(BigInteger n)
        {
            ModuloCounterDecent = 1;
            if (n < 2) return false;
            else if (n < 4) return true;
            else if (n % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i * i < n; i += 2)
                {
                    ModuloCounterDecent++;
                    if (n % i == 0) return false;
                }
            }

            return true;
        }

        private static bool IsPrimeDecentClear(BigInteger n)
        {
            if (n < 2) return false;
            else if (n < 4) return true;
            else if (n % 2 == 0) return false;
            else
            {
                for (BigInteger i = 3; i * i < n; i += 2)
                {
                    if (n % i == 0) return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            BigInteger[] tab = { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

            Console.WriteLine("\n\nAlgorytm przyzwoity: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeDecent(tab[i]) + ";" + tab[i] + ";" + ModuloCounterDecent + "\t");

            }
            Console.WriteLine(" ");

            //------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nAlgorytm przykładowy: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeExample(tab[i]) + ";" + tab[i] + ";" + ModuloCounterExample + "\t");
            }

            //------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n\nAlgorytm przykładowy, pomiar czasu:");
            Stopwatch exampleWatch = new Stopwatch();
            exampleWatch.Reset();
            exampleWatch.Start();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeExampleClear(tab[i]) + ";" + tab[i] + ";" + exampleWatch.ElapsedMilliseconds + "\t");
            }
            exampleWatch.Stop();

            //------------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n\nAlgorytm przyzwoity, pomiar czasu:");
            Stopwatch decentWatch = new Stopwatch();
            decentWatch.Reset();
            decentWatch.Start();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeDecentClear(tab[i]) + ";" + tab[i] + ";" + decentWatch.ElapsedMilliseconds + "\t");
            }
            decentWatch.Stop();
            Console.ReadKey();
        }
    }
}