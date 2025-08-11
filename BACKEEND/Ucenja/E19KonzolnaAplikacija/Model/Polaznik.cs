namespace Ucenje.E19KonzolnaAplikacija.Model
{
    public class Polaznik:Entitet, IComparable<Polaznik>    // IComparable je sučelje (interface), a <Polaznik> je generic(generik)
    {
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string? OIB { get; set; }
        public string? Email { get; set; }

        public int CompareTo(Polaznik? other)
        {
            return Prezime.CompareTo(other.Prezime);
        }
    }
}
