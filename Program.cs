using System;
using System.Collections;
using System.Collections.Generic;
namespace HashTableBornova
{
    
    class Program
    {
      
        public static void Main(string[] args)
        { // Creates and initializes a new Hashtable.
            var BornovaMah = new Hashtable();
            BornovaMah.Add("ERZENE ", 35135);
            BornovaMah.Add("KAZIMDİRİK", 33934);
            BornovaMah.Add("YEŞİLOVA ", 31008);
            BornovaMah.Add("ATATÜRK", 28912);
            BornovaMah.Add("İNÖNÜ", 25778);
            BornovaMah.Add("MEVLANA ", 25492);
            BornovaMah.Add("DOĞANLAR", 21461);
            BornovaMah.Add("RAFET PAŞA", 19476);
            BornovaMah.Add("NALDÖKEN ", 9892);
            BornovaMah.Add("ZAFER", 9876);

            //INCREASING THE POPULATION
            char firstLetter;
            Console.Write("Enter the first letter of county which you want to increase it's population: ");
            firstLetter = Console.ReadLine()[0];
            // Displays the Hashtable.
            Console.WriteLine("The Hashtable contains the following:");

            IDictionaryEnumerator enumerator = BornovaMah.GetEnumerator();

            while (enumerator.MoveNext())
            {
                string key = enumerator.Key.ToString();
                int value = enumerator.Value.GetHashCode();

                Console.WriteLine((key, value));


                
            }
            List<string> list = new List<string>();
            foreach (object item in BornovaMah.Keys) 
            {
                string countyName = (string)item;
                if (countyName[0].CompareTo(firstLetter) == 0)
                {
                    list.Add(countyName);
                }
            }
            foreach (string item in list)
            {

                BornovaMah[item] = (int)BornovaMah[item] + 1;
            }
            Console.WriteLine("After increasing the population");

            foreach (DictionaryEntry entry in BornovaMah)

          
            {
               // The new population
                Console.WriteLine("{0},{1}", entry.Key, entry.Value);
                
      
            }
        }
        }
    }

