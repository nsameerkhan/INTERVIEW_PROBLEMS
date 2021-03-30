using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1500, 2000000, 3000000, 3, 22, 60, 90, 10000 };
            //Console.WriteLine(ans);
            playflow(a);
        
          }
        public static void message()
        {
            Console.WriteLine("**********WELCOME TO THE NUMBER GAME**********");
            Console.WriteLine("ENTER THE PLAYER1 NAME:");
            string player1 = Console.ReadLine();
            Console.WriteLine("ENTER THE PLAYER2 NAME:");
            string player2 = Console.ReadLine();
            Console.WriteLine("PLAYER1:{0}", player1);
            Console.WriteLine("PLAYER2:{0}", player2);
        }
        public static void playflow(int[] ma)
        {
            message();
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < ma.Length / 2; i++)
            {
                sum1 = sum1 + ma[i];
            }
            for (int j = ma.Length - 1; j >= ma.Length / 2; j--)
            {
                sum2 = sum2 + ma[j];
            }
            if (sum1 > sum2)
            {
                int i = 0;
                int j = ma.Length - 1;
                while (i < j)
                {
                    l1.Add(ma[i]);
                    l2.Add(ma[j]);
                    i++;
                    j--;
                }
            }
            else if (sum1 < sum2)
            {
                int i = 0;
                int j = ma.Length - 1;
                while (i < j)
                {
                    l1.Add(ma[j]);
                    l2.Add(ma[i]);
                    i++;
                    j--;
                }

            }
            else
            {
                int i = 0;
                int j = ma.Length - 1;
                while (i < j)
                {
                    l1.Add(ma[j]);
                    l2.Add(ma[i]);
                    i++;
                    j--;
                }

            }
            foreach (var ans1 in l1)
            {
                Console.Write(ans1 + "\t");
            }
            Console.WriteLine("player1 score {0}:", l1.Sum());
            Console.WriteLine("--------------------------------------");
            foreach (var ans2 in l2)
            {
                Console.Write(ans2 + "\t");
            }
            Console.WriteLine("player2 score {0}:", l2.Sum());
            string msg = welcome(l1.Sum(), l2.Sum());
            Console.WriteLine(msg);
        }
        public static string welcome(int player1, int player2)
        {
            string x = "";
            if (player1 > player2)
            {
                x = "****************Player1 win the match****************";
            }
            else if (player1 == player2)
            {
                x = "***************DRAW the match****************";
            }
            else
            {
                x = "***************Player2 win the match****************";
            }


            return x;
        }
    }
}
