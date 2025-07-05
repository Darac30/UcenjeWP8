

using System.Threading.Channels;

namespace Ucenja
{
    internal class E05UvjetnoGrananjeSwitch
    {

        public static void Izvedi() 
        {

            Console.WriteLine("E05UvjetnoGrananjeIf");

            // switch radi s tipovima podataka: int, string, char i odredjeni ostali


            Console.Write("Unesi ocjenu brojem: ");
            int broj = int.Parse(Console.ReadLine());

            switch (broj) {

                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                  
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odlican");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Pa i to bi mogle biti ocjene ali nisu");
                    break;
                default:
                    Console.WriteLine("nije ocjena");
                    break;



            }
        
        
        
        
        
        
        
        
        
        }







    }
}
