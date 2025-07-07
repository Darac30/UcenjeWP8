

namespace Ucenja.E14KlasaObjekt.edunova
{
    public class Grupa
    {
        public int Sifra { get; set; }

        public string Naziv { get; set; } = "";

        public Smjer Smjer { get; set; } = new Smjer();   // ide ovako zato što je vanjski ključ

        public string? Predavac { get; set; }

        public Polaznik[]? Polaznici { get; set; }    // lista polaznika koja može biti null


    }

    // tablicu "članovi" ovdje nismo nigdje unijeli jer se ona sastoji od samo dva vanjska ključa;
    // kada bismo u toj tablici imali još nekih atributa osim navedenih, tada bismo ju unijeli.
}
