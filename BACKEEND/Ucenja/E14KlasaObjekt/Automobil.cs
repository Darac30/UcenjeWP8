using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenja.E14KlasaObjekt
{
    public class Automobil
    {
        public int Sifra { get; set; }
        public string Marka { get; set; } = ""; // ovo ="" znači da ne može biti null

        public bool  Automatik { get; set; }

        public DateTime? DatumProizvodnje { get; set; }

        public decimal Cijena { get; set; }


    }
}
