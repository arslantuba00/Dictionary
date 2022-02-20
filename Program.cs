using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> dictionary = new MyDictionary<string, int>();

            dictionary.Add("Tubiş", 1);
            dictionary.Add("Fırat", 2);
            dictionary.Add("Tuna", 3);

            dictionary.Yazdir();

            Console.ReadLine();
        }
    }
}
