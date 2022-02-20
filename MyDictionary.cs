using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<T,U>
    {
        T[] dictionarykey;
        U[] dictionaryvalue;

        public MyDictionary()
        {
            dictionarykey = new T[0];
            dictionaryvalue = new U[0];

        }

        public void Add(T anahtar, U deger)
        {
            T[] tempkey = dictionarykey;
            U[] tempvalue = dictionaryvalue;

            dictionarykey = new T[dictionarykey.Length + 1];
            dictionaryvalue = new U[dictionaryvalue.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                dictionarykey[i] = tempkey[i];
                dictionaryvalue[i] = tempvalue[i];
            }

            dictionarykey[dictionarykey.Length - 1] = anahtar;
            dictionaryvalue[dictionaryvalue.Length - 1] = deger;

            
           
        }
        
        public void Yazdir()
        {

            for (int i = 0; i < dictionarykey.Length; i++)
            {
                Console.WriteLine("Anahtar: " + dictionarykey[i] + " Değer: " + dictionaryvalue[i]);
            }

        }
    }
}
