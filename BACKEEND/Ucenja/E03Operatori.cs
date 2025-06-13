
namespace Ucenja
{
    internal class E03Operatori
    {
        public static void Izvedi()

        {
            Console.WriteLine("E03Operatori");

            // = dodijeljivanje vrijednosti s desne na lijevu stranu

            // + - 

            // + kao operator nadoljepljivanja

            string grad = "Osijek";

            string ime = "Edunova";

            Console.WriteLine(grad + " " + ime + " " + 5); // ovo nije najbolja praksa

            Console.WriteLine("{0} {1} {2}", grad, ime, 5); // ova linija odradit će isti posao


            // operator modulo (%) -> parnost broja

            Console.WriteLine(8%2);

            int b = 9 % 2;

            Console.WriteLine(b);


            // uvećanje broja za 1

            int i = 0;

            i = i + 1; // uvećan za 1

            i += 1;

            i++;

            ++i;

            // increment i decrement (i++, ++i, i--, --i)

            int k = 1, j = 0;

            k = ++k - j++; // k=2-0, j=1

            Console.WriteLine(--k+j++); // 1 + 1 = 2








        }



    }
}
