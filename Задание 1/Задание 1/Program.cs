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

        static void Main(string[] args)
        {
            int K, S;
            Read(out K, out S);
        }
    }
}


