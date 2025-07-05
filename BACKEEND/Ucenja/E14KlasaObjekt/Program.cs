

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

            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Ime);
            }

            // ovdje je Mjesto na osoba null
            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            // ovdje na osoba dodjeljujemo Mjesto na novu instancu klase mjesto s vrijednošću naziva Osijek
            osoba.Mjesto = new() { Naziv = "Osijek" };

            // ovdje Mjesto nije null i naziv je postavljen
            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            osoba.Ime = "Pero";

            osoba.Mjesto.Zupanija = new Zupanija() { Naziv = "OBŽ", Zupan = new() { Ime = "Nataša" } };

            // Koji je smisao OOP-a

            Console.WriteLine(osoba.Mjesto.Zupanija.Zupan.Ime);

            // ispisati Pero s objekta osoba
            Console.WriteLine(osoba.Ime);

            // ispisati OBŽ s objekta
            Console.WriteLine(osoba.Mjesto.Zupanija.Naziv);

            // ispisati Osijek s objekta osoba
            Console.WriteLine(osoba.Mjesto?.Naziv);
        }

        // Zadatak: Kreirati klasu Automobil s pet svojstava

        public static void AutomobilZadatak()
        {
            Automobil automobil = new();
            automobil.Sifra = 1;
            automobil.Marka = "Mercedes";
            automobil.Automatik = false;
            automobil.DatumProizvodnje = new DateTime(1991, 11, 1);
            automobil.Cijena = 14525.20M;

            Console.WriteLine(automobil.DatumProizvodnje);
            
            
        }
    


    }
}
