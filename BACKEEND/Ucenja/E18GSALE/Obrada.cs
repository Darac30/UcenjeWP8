using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenja.E18GSALE
{
    public class Obrada<T> // T je oznaka TYPE, a može biti bilo koje slovo ili niz slova
    {
        public T? PredmetObrade { get; set; }

        [Obsolete("Ovo više nemoj koristiti")]  // deprecated; označava da smo to prestali korsititi, ali ga nećemo izbaciti jer kod se možda još koristi
        public void Posao()
        {
            Console.WriteLine("Obrađujem {0}",PredmetObrade);

            // Primjer depricated u C#
            // Thread.ResetAbort();
        }
    }
}
