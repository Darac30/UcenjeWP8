using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenja.E14KlasaObjekt
    // klasa je opisnik objekta -> naučiti napamet
{
    internal class Osoba
    {
        // klasa se sastoji od svojstava
        // princip učahurivanja (OOP princip)

        // nazivi svojstava se pišu velikim početnim slovom (ovdje je to Sifra)
        public int Sifra { get; set; }

        public string? Ime { get; set; } // upitnik znači da svojstvo može biti null

        public string Prezime { get; set; } = ""; // "" će postaviti prazno, neće biti null

        public DateTime? DatumRodenja { get; set; }

        // klasa se sastoji od metoda
        // ova metoda nije static!

        public void IspisiImePrezime()
        {
            // ključna riječ this se odnosi na klasu u kojoj se nalazi
            Console.WriteLine(this.Ime + " " + Prezime);
        }

        // statične metode se pozivaju na klasi, a nestatične na objektu

        public static void Primjer()
        {
            Console.WriteLine("Primjer statične metode");

            
        }

    }
}
