using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewproblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 9, 9 };
            arrray(a);
            //int[] a = { 0,0,0,1 };
            //Console.WriteLine(add1inarray(a));
            add1values(a);

        }
        public static int arrray(int[] ma)
        {
            if (ma[ma.Length - 1] > ma[0])
            {
                return ma[0];
            }
            else
            {
                return ma[ma.Length - 1];
            }


        }
        public static int add1inarray(int[] ma)
        {
            int values = 0;
            for (int i = 0; i < ma.Length; i++)
            {
                values = (values * 10) + ma[i];
            }
            return values + 1;
        }
        public static void add1values(int[] ma)
        {
            int count = 0;
            for (int i = ma.Length - 1; i >= 0; i--)
            {
                if (ma[i] == 9)
                {
                    ma[i] = 0;
                    count++;
                }
                else if (count == ma.Length)
                {
                    int[] newma = new int[ma.Length + 1];
                    ma = newma;

                }
                else
                {
                    ma[i]++;
                    break;

                }


            }
            foreach (var ans in ma)
            {
                Console.Write(ans + " ");
            }
        }
        
    }
}
