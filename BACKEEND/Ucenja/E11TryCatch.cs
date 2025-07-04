using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenja
{
    internal class E11TryCatch
    {
        public static void Izvedi()
        {
            Console.WriteLine("Catch");

            int b = 0;

            /*
            // try blok se uvijek izvodi
            try
            {
                // ukoliko je bačena iznimka, ona se hvata u catch
                b = int.Parse(Console.ReadLine());

            }

            catch 
            {
                // ovdje imam mogućnost obraditi bačenu iznimku
                Console.WriteLine("Niste unijeli broj");
            }


            Console.WriteLine(b+1);
            */

            while (true)
            {
                try
                {
                    Console.Write("Unesi broj: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");

                   
                }
            }

            Console.WriteLine(b+1);

            // Napisati program koji za unesena dva cijela broja daje njihov zbroj

            int pb, db;

            while (true) 
            {
                Console.Write("Unesi prvi broj:");
                try
                {
                    pb = int.Parse(Console.ReadLine());
                    break; // break ide nakon metode koja uspješno prođe, a mogla je baciti iznimku
                }
                catch
                {
                    Console.WriteLine("Niste unijeli prvi broj");
                    
                }
                  
            }

            while (true)
            {

                Console.Write("Unesi drugi broj: ");

                try
                {
                    db = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli drugi broj");

                }

            }

            Console.WriteLine("Rezultat {0} + {1} = {2}", pb, db, pb+db);

            // dobro osiguranje unosa broja

            string UnosniNizZnakova;

            while (true) {

                Console.Write("Unesi broj: ");
                UnosniNizZnakova = Console.ReadLine().Trim();  // Trim briše razmake s lijeve i desne strane

                if (UnosniNizZnakova.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugačak niz znakova");
                    continue;
                }
                // siguran sam da unosni niz znakova nema razmake prije ili poslije i nije duži od 9 znakova

                try
                {
                    b = int.Parse(UnosniNizZnakova);
                    if (b > 10000) 
                    {
                        Console.WriteLine("Uneseni broj je prevelik, unesite manji broj!");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli broj!");
                    
                }
            }

            Console.WriteLine("Unesen je broj {0}", b);

            // nije dana puna sintaksa try catch, ostalo nakon OOP-a
            
            
        }   



        

    }
}
