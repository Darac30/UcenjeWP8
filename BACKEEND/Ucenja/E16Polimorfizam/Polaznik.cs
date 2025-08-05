using System.Text;

namespace Ucenja.E16Polimorfizam
{
    public class Polaznik : Osoba
    {
        public string? Telefon { get; set; }

        public override void Greska(string poruka)
        {
            // todo: Zavrsi
            //pojam tehnički dug: technical debt
        }

        public override string Pozdravi()
        {
            return new StringBuilder().Append("Dobar dan ").Append(Ime).Append(", polazniče ").Append(Telefon).ToString();
        }
    }
}
