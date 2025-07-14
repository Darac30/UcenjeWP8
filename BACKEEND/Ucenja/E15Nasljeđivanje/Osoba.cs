

namespace Ucenja.E15Nasljeđivanje
{
    public class Osoba : Object     // sve klase nasljeđuju klasu Object htjele to one ili ne
    {
        public int Sifra { get; set; }

        public string Ime { get; set; } = "";

        public string Prezime { get; set; } = "";

        public string? Email { get; set; }


        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
