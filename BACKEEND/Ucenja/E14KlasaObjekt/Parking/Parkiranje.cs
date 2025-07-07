
namespace Ucenja.E14KlasaObjekt.Parking
{
    public class Parkiranje
    {
        public int Sifra { get; set; }

        public DateTime? DatumUlaska { get; set; }

        public DateTime? DatumIzlaska { get; set; }

        public string RegistarskaOznaka { get; set; }

        public ParkirnoMjesto ParkirnoMjesto { get; set; } = new ParkirnoMjesto();
    }
}
