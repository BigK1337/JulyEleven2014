using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rewind;
            Console.Write("Enter something: ");

            for (int x = 0; x < 100; x++)
            {
                rewind = Console.ReadLine();
                dniwer(rewind);
                Console.WriteLine("");
                Console.Write("Enter another: ");
            }
        }

        public static void dniwer (string rewind)
        {
            int y = rewind.Length;
            Stack<string> reverse = new Stack<string>();
            y = y - 1;
            string[] tout;
            tout = rewind.Split(new Char[] { ' ' });
            foreach (string s in tout)
            {
                reverse.Push(s);
            }
            foreach(string r in reverse)
            {
                Console.Write(r + " ");
            }
            
        }
    }
}
