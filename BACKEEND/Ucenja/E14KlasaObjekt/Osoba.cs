

namespace Ucenja.E14KlasaObjekt
    // klasa je opisnik objekta -> naučiti napamet
{
    public class Osoba
    {
        // klasa se sastoji od svojstava
        // princip učahurivanja (OOP princip)

        // nazivi svojstava se pišu velikim početnim slovom (ovdje je to Sifra)
        public int Sifra { get; set; }

        public string? Ime { get; set; } // upitnik znači da svojstvo može biti null

        public string Prezime { get; set; } = ""; // "" će postaviti prazno, neće biti null

        public DateTime? DatumRodenja { get; set; }

        // prvi tekst Mjesto je klasa, a drugi tekst Mjesto je svojstvo
        // ovo je veza 1:n u bazi
        public Mjesto? Mjesto { get; set; }

        // ovo je veza n:n u bazi
        // koristimo nizove u slučaju da postoji više od 1 mjesta

        public Mjesto[]? Mjesta { get; set; }

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
