namespace Ucenja
{
    internal class E02Varijable
    {
        public static void Izvedi() 
        {
            // ovo je unutar metode

            Console.Write("Unesi svoje ime: ");

            // deklaracija varijable
            // tip podatka i ime

            string ime;

            // dodijeljivanje vrijednosti varijabli
            ime = Console.ReadLine();

            // ispisivanje sadržaja varijable
            Console.WriteLine(ime);

            Console.WriteLine(ime[0]); // 1. znak unesenog imena
            // string je niz znakova i prvi znak u tom nizu se nalazi na indeksu 0


            // deklariranje i dodjeljivanje u istoj liniji
            char znak = '@';   // može sadržavati samo 1 znak i u pravilu ga nećemo koristiti

            Console.WriteLine(znak);

            Console.WriteLine((int)znak);  // (int) je cast; znakovi su brojevi prema ASCII tablici

            int cijeliBroj = int.MaxValue;

            Console.WriteLine(int.MaxValue);

            Console.WriteLine(cijeliBroj+1);

            Console.Write("Unesi broj cipela: ");

            int brojCipela = int.Parse(Console.ReadLine());

            Console.WriteLine(brojCipela+1);

            bool logickiTip = true; // druga vrijednost je false

            float decimalniBroj = 3.14f;

            double velikiDecimalniBroj = 3.14;

            decimal db = 3.14M;









            



        
        
        
        
        }


    }
}
