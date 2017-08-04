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

        static void Main(string[] args)
        {
            int K, S, max = 0, min = 0;
            Read(out K, out S);

            if (S == 1)
            {
                max = Stepen(K);
                min = max;
            }

            Console.WriteLine("{0} {1}", max, min);
            Console.ReadLine();
        }
    }
}


