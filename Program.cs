using System;

namespace Exercises
{
    class Program
    {
        static string fullName;
        static string birthDate;
        static string Confirmation;
        static int Any;
        static void Main(string[] args)
        {
           Fase1();
           Fase3();
           Console.WriteLine("\nEn resum\n" + fullName + "\n" + birthDate + "\n" + Confirmation);
        }
        static void Fase1()
        {
            Console.WriteLine("Introdueix el teu nom");
            string Nom = Console.ReadLine();
            
            Console.WriteLine("Introdueix el teu cognom");
            string Cognom1 = Console.ReadLine();
            
            Console.WriteLine("Introdueix el teu segon cognom");
            string Cognom2 = Console.ReadLine();

            fullName = "El meu nom és " + Nom + " " + Cognom1 + " " + Cognom2;

            //Console.WriteLine("El teu nom és: " + cognom1 + " " + cognom2 + ", " + nom); //i dont like it

            Console.WriteLine("Introdueix el teu dia d'aniversari en nombre");
            int Dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdueix el teu mes d'aniversar en nombre");
            int Mes = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introdueix el teu any d'aniversari en nombre");
            Any = int.Parse(Console.ReadLine());
            birthDate = $"Vaig nèixer el {Dia}/{Mes}/{Any}";
            //Console.WriteLine($"La teva data de naixement és: {dia}/{mes}/{any}");
        }
        static void Fase2()
        {
            const int initialYear = 1948;
            int everyLeapyear = 4;

            int contLeapyear = 0;
            
            Console.WriteLine("Introduce your birth year");
            int birth = int.Parse(Console.ReadLine());

            for ( int i = initialYear; i <= birth; i++)
            {
                if (i % everyLeapyear == 0)
                {
                    contLeapyear++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Between {initialYear} and {birth} there were {contLeapyear} leap years");
        }
        static void Fase3()
        {
            const int initialYear = 1948;
            int everyLeapyear = 4;
            int contLeapyear = 0;
            
            Console.WriteLine("\nAquests són tots els any de traspàs entre el 1948 i la teva data de naixement:\n");

            for ( int i = initialYear; i <= Any; i++)
            {
                if (i % everyLeapyear == 0)
                {
                    contLeapyear++;
                    Console.WriteLine(i);
                }
            }
            if (Any % 4 == 0)
            {
                //bool Traspas = true?;
                Confirmation = "El meu any de naixement és de traspás";
            }
            else Confirmation = "El meu any de naixement no és de traspás";
        }
    }
}
