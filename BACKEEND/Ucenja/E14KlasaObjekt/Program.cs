

namespace Ucenja.E14KlasaObjekt
{
    internal class Program
    {
        // 5. vrsta metode - konstruktor
        // Naziv mora biti jednak nazivu klase

        public Program()  // nema u nazivu voida niti returna
        {
            Console.WriteLine("Klasa/objekt");

            // Objekt je pojavnost (instanca) klase -> ovo naučiti napamet

            // Osoba (primjetiti veliko slovo O) je klasa, a osoba (s malim slovom o) je objekt (još se naziva instanca
            // ili varijabla)
            Osoba osoba = new Osoba();  // pozvali smo konstruktor od klase Osoba (new)

            // postavljanje vrijednosti za svojstva objekta

            osoba.Sifra = 1; // pozvao si setter (učahurivanje)
            //osoba.Ime = "Pero"; (namjerno ime ostavljamo null jer ono može biti null (?))
            osoba.Prezime = "Perić";
            osoba.DatumRodenja = new DateTime(1980, 12, 7);

            // ponovit ću s uzimanjem vrijednosti od naših korisnika

            //osoba.Sifra = Pomocno.ucitajCijeliBroj("Unesi šifru osobe"); // usporediti s linijom 22
            //osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            //osoba.DatumRodenja = new DateTime(
            //    Pomocno.ucitajCijeliBroj("Unesi godinu rodjenja"),
            //    Pomocno.ucitajCijeliBroj("Unesi mjesec rodjenja"),
            //    Pomocno.ucitajCijeliBroj("Unesi dan rodjenja")
            //    );

            // korištenje vrijednosti svojstava
            Console.WriteLine(osoba.Prezime); // pozvao si getter (učahurivanje)
            Console.WriteLine(osoba.Ime); // ispiše "" (prazno)
            Console.WriteLine(osoba.Ime??"nije postavljeno"); // ime može biti null, stoga ?? znači što će biti ako je null. Konkretno,
            // ako je ime null, ispiši nije postavljeno.

            // nestatična metoda se zove s objekta
            osoba.IspisiImePrezime();

            // osoba.Primjer(); NE MOŽEŠ POZVATI STATIČNU METODU S OBJEKTA!

            Osoba.Primjer();  // statičnu metodu pozivamo s klase

            // Osoba.IspisiImePrezime();   // na klasi se ne može pozvati ne statična metoda

            Osoba[] osobe = new Osoba[3];

            // skraćeni oblik postavljanja vrijednosti svojstava

            osobe[0] = new Osoba()
            {
                Ime = "Marija",
                Prezime = "Kat",
                Sifra = 2,
                DatumRodenja = new DateTime(1982, 1, 2)
            };

            osobe[1] = new() { Ime = "Ante" };

            osobe[2] = osoba;






        }

    


    }
}
