
using System.Text;

namespace Ucenja.E15Nasljeđivanje
{   // Apstraktna klasa je ona klasa koja nema implementaciju (instancu), već služi da bi se naslijedila i proširila
    public abstract class Osoba : Object     // sve klase nasljeđuju klasu Object htjele to one ili ne
    {
        public int Sifra { get; set; }

        public string Ime { get; set; } = "";

        public string Prezime { get; set; } = "";

        public string? Email { get; set; }


        public override string ToString()
        {
            //return Ime + " " + Prezime;

            return new StringBuilder().Append(Ime).Append(' ').Append(Prezime).ToString();
        }
    }
}
