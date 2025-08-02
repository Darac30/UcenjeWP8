

namespace Ucenja.E15Nasljeđivanje
{
    // klasa Polaznik naslijeđuje sva javna i zaštićena svojstva klase Osoba te svih drugih klasa koje osoba naslijeđuje
    public class Polaznik : Osoba  
    {
        public string Telefon { get; set; } = "";

        // prepisivanje metoda (method override)

        public override string ToString()
        {
            return base.ToString() + " " + Telefon;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var p = obj as Polaznik;  
            if (p.Ime.Equals(Ime) &&
                p.Prezime.Equals(Prezime) && 
                p.Telefon.Equals(Telefon)) return true;

            return false;
            {
                
            }
        }


    }
}
