

namespace Ucenja
{
    internal class E01UlazIzlaz
    {

        // unutar klase radimo metodu
        public static void Izvedi() 
        {


            Console.Write("Pozdrav svijetu");
            Console.WriteLine("Isti red");
            Console.WriteLine("Osijek je \n super");
            Console.WriteLine("\t\t ovo je uvuceno");
            Console.Write("Unesi svoje ime: ");

            // varijabla ime
            string ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste {0}", ime);
        


        } // kraj metode



    }   // kraj klase
}   // kraj imenskog prostora (namespace)
