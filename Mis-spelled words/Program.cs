using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_spelled_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTAINS WORDS");
            Console.WriteLine("speed" +"\t"+ "time" +"\t"+ "coffee"+"\t"+ "saturday"+"\t"+ "man");
            string value =Console.ReadLine();
            misspelled(value);
        }
        public static void misspelled(string a)
        {
            int count = 0;
           
            List<char> l1 = new List<char> {'s','p','e','e','d'};
            List<char> l2 = new List<char> { 't', 'i', 'm', 'e' };
            List<char> l3 = new List<char> { 'c', 'o', 'f', 'f', 'e', 'e' };
            List<char> l4 = new List<char> { 's','a','t','u','r','d','a','y' };
            List<char> l5 = new List<char> { 'm', 'a', 'n' };
            for (int i = 0; i < a.Length; i++)
            {
                
                if (a[0] == l1.First()||a[0]==l2.First()||a[0]==l3.First()||a[0]==l4.First()||a[0]==l5.First())
                {
                    if (l1.Contains(a[i])||l2.Contains(a[i])||l3.Contains(a[i])||l4.Contains(a[i])||l5.Contains(a[i]))
                    {
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("invalid name");
                    break;
                }
               
            }
            if (count == a.Length)
            {
                if (l1.Count == count)
                {
                    foreach (var ans in l1)
                    {
                        Console.Write(ans);
                    }
                    Console.WriteLine();
                }
                else if (l2.Count == count)
                {
                    foreach (var ans in l2)
                    {
                        Console.Write(ans);
                    }
                    Console.WriteLine();
                }
                else if(l3.Count==count)
                {
                    foreach (var ans in l3)
                    {
                        Console.Write(ans);
                    }
                    Console.WriteLine();
                }
                else if(l4.Count==count)
                {
                    foreach (var ans in l4)
                    {
                        Console.Write(ans);
                    }
                    Console.WriteLine();

                }
                else if (l5.Count == count)
                {
                    foreach (var ans in l5)
                    {
                        Console.Write(ans);
                    }
                    Console.WriteLine();

                }
            }



        }
       
    }
}
