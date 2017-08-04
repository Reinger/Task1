using System;
using System.IO;

namespace Задание__1
{
    class Program
    {
        static void Trans(out double K, out double S, string Str)
        {
            string[] MStr = Str.Split(' ');
            S = Double.Parse(MStr[0]);
            K = Double.Parse(MStr[1]);
        }

        static void Read(out double K, out double S)
        {
            FileInfo File = new FileInfo("INPUT.TXT");
            StreamReader Input = File.OpenText();
            string Str = Input.ReadLine();
            Input.Close();
            Trans(out K, out S, Str);
        }

        static void Write (double max, double min)
        {
            FileInfo File = new FileInfo("OUTPUT.TXT");
            StreamWriter Output = File.CreateText();
            Output.WriteLine("{0} {1}",max,min);
            Output.Close();
        }

        static double Stepen(double K)
        {
            double max = 1;
            for (int i = 1; i < K; i++) max = max * 10;
            return max;
        }

        static double Min(double stepen, double S)
        {
            double min = stepen, k = 1;
            while (S>=9)
            {
                S -= 9;
                min = min + k*9;
                k = 1 * 10;
            }
            min = min + S * k;
            return min;
        }

        static double Max(double stepen, double S)
        {
            double max = stepen * 9;
            while (S >= 9)
            {
                stepen /= 10;
                max += stepen * 9;
                S -= 9;
            }
            max += stepen / 10 * S;
            return max;
        }

        static void Main(string[] args)
        {
            double K, S, max = 0, min = 0;
            //Read(out K, out S);
            S = Double.Parse(Console.ReadLine());
            K = Double.Parse(Console.ReadLine());

            double stepen = Stepen(K);
            if (S == 1)
            {
                max = stepen;
                min = stepen;
            }
            else if (S < 10)
            {
                min = stepen + S - 1;
                max = stepen * S;
            }
            else
            {
                min = Min(stepen,S-1);
                max = Max(stepen, S - 9);
            }

            //if (min > max) min = max;

            Console.WriteLine("{0} {1}", max, min);
            Console.ReadLine();
            //Write(max, min);
        }
    }
}
