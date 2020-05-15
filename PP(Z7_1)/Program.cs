using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z7_1_
{
    class Program
    {
        static int numberOfUpWords(StringBuilder input)
        {
            int ret = 0, ind = 0;
            while (ind < input.Length)
            {
                int nUCase = 0, nLCase = 0;
                while (ind < input.Length && char.IsLetter(input[ind]))
                {
                    if (char.IsUpper(input[ind])) nUCase++;
                    if (char.IsLower(input[ind])) nLCase++;
                    ind++;
                }
                if (nUCase > 0 && nLCase == 0) ret++;
                while (ind < input.Length && !char.IsLetter(input[ind]))
                    ind++;
            }
            return ret;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку str: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Кол-во слов, содержащие только прописные буквы: " + numberOfUpWords(str));
            Console.ReadLine();
        }
    }
}
