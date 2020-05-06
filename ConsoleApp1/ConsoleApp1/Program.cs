using System;
using System.Numerics;
using System.Diagnostics;

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
                for (BigInteger i = 3; i*i < n; i += 2)
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
            // BigInteger[] tabSmall = { 100913, 1009139, 10091401, 100914061, 1009140611 };
            /*
            Console.WriteLine("Algorytm przyzwoity: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeDecent(tab[i]) + "\t" + tab[i] + "\t" + ModuloCounterDecent + "\t");
                
            }
            Console.WriteLine(" ");

            Console.WriteLine("Algorytm przykładowy: ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeExample(tab[i]) + "\t" + tab[i] + "\t" + ModuloCounterExample + "\t");

            }
            */
            /*
            Console.WriteLine("Algorytm przykładowy, pomiar czasu:");
            Stopwatch exampleWatch = new Stopwatch();
            exampleWatch.Reset();
            exampleWatch.Start();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeExampleClear(tab[i]) + "\t" + tab[i] + "\t" + exampleWatch.ElapsedMilliseconds + "\t");
            }
            exampleWatch.Stop();
            */
            Console.WriteLine("Algorytm przyzwoity, pomiar czasu:");
            Stopwatch decentWatch = new Stopwatch();
            decentWatch.Reset();
            decentWatch.Start();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(IsPrimeDecentClear(tab[i]) + "\t" + tab[i] + "\t" + decentWatch.ElapsedMilliseconds + "\t");
            }
            decentWatch.Stop();
            Console.ReadKey();
        }
    }
}
