namespace Ucenja.E17Vjezbanje
{
    public class Zadatak1
    {

        private int brojIzvodenja = 0;
        
        public void Izvedi()
        {
            brojIzvodenja++;
            int pb = Pomocno.ucitajCijeliBroj("Unesi prvi broj");
            int db = Pomocno.ucitajCijeliBroj("Unesi drugi broj");
            Console.WriteLine("{0} + {1} = {2}", pb, db, pb + db);
            Console.WriteLine("Završio {0}. izvođenje", brojIzvodenja);

        }
         
    }
}
