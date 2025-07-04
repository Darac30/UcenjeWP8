using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenja
{
    internal class E10ForEach
    {
        public static void Izvedi()
        {
            Console.WriteLine("foreach");

            Console.Write("Unesi ime grada: ");

            string grad = Console.ReadLine();

            // ispiši svako slovo grada jedno ispod drugog

            for(int i=0; i<grad.Length; i++)
            {

                Console.WriteLine(grad[i]);

            }

            Console.WriteLine("*******************************************************");

            foreach (char z in grad)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("*********************************************************");

            int[] brojevi = { 1, 23, 5, 6, 13, 43, 88, 23, 18 };

            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }

        }






    }
}
