﻿

namespace Ucenja
{
    internal class E07ForPetlja
    {
        public static void Izvedi() 
        {
            Console.WriteLine("E07ForPetlja");

            // s dosadašnjim znanjem ispiši Hrvatska - Češka 5:1, i to 10x

            // rješenje, ali nije best practice, koji se mijenja s godinama

            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");
            Console.WriteLine("Hrvatska - Češka 5:1");



            Console.WriteLine("*****************************");

            for(int i = 0; i < 10; i++) // ovdje ne dolazi ;
            {

                Console.WriteLine("Hrvatska - Češka 5:1");








            }


            Console.WriteLine("*****************************");

            // ispiši prvih 100000 brojeva

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}.", i+1);


            }



            Console.WriteLine("***************************");

            // Ispiši zbroj prvih 100 brojeva

            Console.WriteLine((100/2)*100+100/2); // 4 operacije
            Console.WriteLine(100/2 * (100+1)); // 3 operacije

            int suma = 0;
            for(int i = 0;i < 100;i++)
            {
                suma = suma + i + 1;  // 100 operacija

            }

            Console.WriteLine(suma);

            // Big O notacija

            Console.WriteLine("*******************************");

            // ispiši brojeve od 10 do 1 

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("*******************************");

            // ispiši svaki 5. broj od 1 do 90

            for(int i = 1; i <= 90; i+=5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*******************************");

            // ispiši sve parne brojeve od 79 do 123

            for(int i = 79; i <= 123; i++ )
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("*******************************");

            int odKuda = 2, doKuda = 8;


            // ovome težimo: kod bez konstanti
            for (int i = odKuda; i < doKuda; i++)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("******************************************");

            string grad = "Osijek";

            for (int i = 0; i <grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }


            Console.WriteLine("******************************************");

            // ugnježđivanje petlje

            for(int i = 1; i<=10;  i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.WriteLine();
            }


            Console.WriteLine("******************************************");

            // mogucnost preskakanja (nastavljanja od pocetka) i nasilnog prekida petlje

            for (int i = 1; i < 10; i++)
            {


                if (i == 2)
                {

                    continue; // vraća na početak petlje, zato ja kažem preskače ostatak

                }

                if (i == 7)
                {
                    break; // prekida petlju iako nije i došao do kraja
                
                
                }

                Console.WriteLine(i);  // primjer zauzetih sjedala i ukupnog kapaciteta u kinu



            }


            Console.WriteLine("******************************************");

            // beskonačna petlja

            for (; ; ) 
            
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0}", new Random().Next ());
                Thread.Sleep (100);
            
            }



















        }

















    }
}
