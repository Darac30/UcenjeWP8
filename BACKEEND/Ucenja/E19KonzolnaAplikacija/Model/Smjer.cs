namespace Ucenje.E19KonzolnaAplikacija.Model
{
    public class Smjer:Entitet
    {

        public Smjer()                    // na linijama od 7. do 12. se nalazi konstruktor (kada se metoda zove kao klasa, a nema return, onda je to konstruktor)
        {
            Naziv = "";
            this.Vaucer = false;
            Cijena = 0;
            IzvodiSeOd = DateTime.Now;
            DatumPromjene = DateTime.Now;
        }

        public string Naziv { get; set; }      // na linijama od 15. do 20. su svojstva
        public float? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool? Vaucer { get; set; }

        public DateTime? DatumPromjene { get; set; }

        public override string ToString()
        {
            return "Sifra=" + Sifra + " ,Naziv=" + Naziv + ", Cijena=" + Cijena +
                ", IzvodiSeOd=" + IzvodiSeOd + ", Verificiran=" + Vaucer; 
        }

    }
}
