using System;

namespace FirstOrLast
{
	class Program
	{
		static void Main(string[] args)
		{
            //programm palub kasutajal sisestada ees- ja perekonnanime
            //programm kontroll andmete pikkust (eraldi nimi ja perekonnanimi)
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi
            //if'iga pikkuse teada andmine


            Console.WriteLine("Palun, sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");


            Console.WriteLine("Palun, sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length} sümbolit.");

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi, kuna sisaldab rohkem sümboleid.");
            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi, kuna sisaldab rohkem sümboleid.");
            }
            else
            {
                Console.WriteLine("Mõlemad nimed on sama pikad.");
            }
        }
	}
}
