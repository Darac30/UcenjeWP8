using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenja.E15Nasljeđivanje
{
    // u C# jedna klasa može naslijediti samo jednu nadklasu
    public class Predavac : Osoba
    {
        public string IBAN { get; set; } = "";
    }
}
