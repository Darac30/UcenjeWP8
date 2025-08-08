

namespace Ucenja.E18GSALE

    // Ekstenzije su metode koje možemo nakačiti na bilo koji tip podatka za koji je ekstenzija napisana; ako je napisana za Object može ići na bilo koji tip podatka
{
    public static class Ekstenzije
    {

        public static void EdunovaProvjera(this string s)
        {
            Console.WriteLine(s.Substring(2,4));


        }

        public static int Broj(this IObrada obrada)  // Broj se može nakačiti na instancu bilo koje klase koja je implementirala IObradu

        {
            string s = obrada.Metoda();
            return s.Length;
        }
    }
}
