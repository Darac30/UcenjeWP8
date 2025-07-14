using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenja.E15Nasljeđivanje
{
    public class Program
    {
        public Program() 
        {
            Console.WriteLine("Nasljeđivanje");

            var oso = new Osoba() { Ime = "Marija", Prezime = "Kaz" };  // s lijeve strane je moglo pisati i Osoba oso

            Predavac pre = new() { Ime = "Karlo", Prezime = "Lot", IBAN = "HR3854492133584" }; // ovdje je s lijeve strane naziv klase, a sdesne strane samo new

            Polaznik pol = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-636" };

            Polaznik pol1 = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-636" };

            // što će ispisati? Metode Equals, GetHashCode i ToString se izvode u prvom prolazu iz klase Object i u navodnicima su navedene vrijednosti koje se dobiju

            Console.WriteLine(pol.Equals(pol1)); // False

            // Equals je metoda u nadklasi (Object)
            // ovdje pol i pol 1 imaju iste vrijednosti, ali su 2 različita objekta, zato izbacuje False za njih (ustvari uspoređuje njihove GetHashCodove

            Console.WriteLine(pol.GetHashCode()); // 43942917
            Console.WriteLine(pol1.GetHashCode()); // 59941933

            Console.WriteLine(pol.ToString());

            // 2. prolaz, nakon pisanja prepisanih metoda

            Console.WriteLine(pol);  // ovo je jednako kao da smo pozvali pol.ToString()

            Console.WriteLine(pre);

        }
    }
}
