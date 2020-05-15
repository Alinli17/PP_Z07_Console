using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z7_
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите строку str: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            Console.Write("Введите подстроку substr: ");
            StringBuilder substr = new StringBuilder(Console.ReadLine());
            str.Replace(substr.ToString(), "");
            Console.WriteLine("Измененная строка str: {0}", str);
            Console.ReadKey();
        }
    }
}
