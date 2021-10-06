using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            // initsiaalid lõpetavad punktiga
            //--> Harry Potter --> H. P.

            Console.WriteLine("mis on sinu eesnimi");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("mis on sinu perekonnanimi");
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Tere {userFirstName[0]}. {userLastName[0]}.!");
        }
    }
}
