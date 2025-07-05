namespace Ucenja.E14KlasaObjekt
{
    // POCO - Plain Old C# Object (klase koje imaju samo svojstva nazivamo POCO)
    public class Mjesto
    {
        public string? PostanskiBroj { get; set; }
        public string? Naziv { get; set; }

        public Zupanija? Zupanija { get; set; }
    }
}