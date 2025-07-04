

namespace Ucenja
{
    internal class Pomocno
    {

        /// <summary>
        /// Učitava i vraća string koji korisnik unese putem konzole.
        /// Ako korisnik ne unese ništa, traži ponovni unos dok ne dobije ne-prazan string.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni string.</returns>
        public static string UcitajString(string poruka)
        {
            string s;
            for (; ; )
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length > 0)
                {
                    return s;
                }
                Console.WriteLine("Obavezan unos");
            }
        }

        /// <summary>
        /// Provjerava je li zadani string cijeli broj.
        /// </summary>
        /// <param name="s">String koji se provjerava.</param>
        /// <returns>True ako je string cijeli broj, inače false.</returns>
        public static bool isCijeliBroj(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Učitava cijeli broj s konzole.
        /// Ako unos nije cijeli broj, traži ponovni unos dok ne dobije ispravan cijeli broj.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni cijeli broj.</returns>
        public static int ucitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokušajte ponovno");
                }
            }
        }
    }
}
