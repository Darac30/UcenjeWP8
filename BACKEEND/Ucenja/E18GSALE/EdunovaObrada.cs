using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenja.E18GSALE
{
    public class EdunovaObrada<T> : IObrada where T : Entitet  // mora biti bilo koja klasa koja je naslijedila Entitet
    {
        public T? Entitet { get; set; }

        public string Metoda()
        {
            return "Edunova";
        }

        public void OdradiPosao()
        {
            Posao();
        }

        [Obsolete("Više nemoj koristiti")]
        public void Posao()
        {
            Console.WriteLine(Entitet?.Sifra);
        }

    }
}
