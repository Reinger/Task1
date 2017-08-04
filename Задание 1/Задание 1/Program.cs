using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание__1
{
    class Program
    {
        static void Trans(out int K, out int S, string Str)
        {
            string[] MStr = Str.Split(' ');
            S = Int32.Parse(MStr[0]);
            K = Int32.Parse(MStr[1]);
        }

        static void Read(out int K, out int S)
        {
            FileInfo File = new FileInfo("INPUT.TXT");
            StreamReader Input = File.OpenText();
            string Str = Input.ReadLine();
            Input.Close();
            Trans(out K, out S, Str);
        }

        static int Stepen(int K)
        {
            int max = 1;
            for (int i = 1; i < K; i++) max = max * 10;
            return max;
        }

        static int Min (int stepen, int S)
        {
            int min=0;
            return min;
        }

        static int Max(int stepen, int S)
        {
            int max = stepen*9;
            S = S - 9;
            while (S>=9)
            {
                stepen /= 10;
                max = max + stepen*9;
                S -= 9;
            }
            max = max + stepen / 10 * S;
            return max;
        }

        static void Main(string[] args)
        {
            int K, S, max = 0, min = 0;
            Read(out K, out S);

            int stepen = Stepen(K);

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
                min = Min(stepen, S);
                max = Max(stepen, S);

            }

            Console.WriteLine("{0} {1}", max, min);
            Console.ReadLine();
        }
    }
}


