namespace PersonalRegister
{
    internal class Program
    {
        static PersonalRegister register = new();

        static void Main(string[] args)
        {
            string input = "";

            do {
                Console.Clear();
                Console.WriteLine("Personalregister\n");
                Console.WriteLine("1. Lägg till ny anställd");
                Console.WriteLine("2. Hitta en viss anställd");
                Console.WriteLine("3. Se antalet anställda");
                Console.WriteLine("4. Skriv ut anställda");
                Console.WriteLine("5. Ta bort en viss anställd");
                Console.WriteLine("E. Avsluta applikationen");
                input = Console.ReadLine() ?? "";
                input = input.ToUpper();

                switch (input) {
                    case "1":
                        LäggTillNyPersonal();
                        break;
                    case "2":
                        HittaPersonal();
                        break;
                    case "3":
                        Console.WriteLine($"Det är {register.AntalAnställda} anställda just nu.");
                        break;
                    case "4":
                        register.PrintRegister();
                        break;
                    case "5":
                        TaBortPersonal();
                        break;
                    default:
                        Console.WriteLine("Invalid inputm, please try again");
                        continue;
                    case "E":
                        Console.WriteLine("Avslutar applikationen");
                        break;
                }

                Console.WriteLine("\nKlicka någon tangent för fortsätta");
                Console.ReadLine();
            } while (input != "E");
        }

        static void LäggTillNyPersonal()
        {
            Console.Write("\nSkriv förnamn: ");
            string? förnamn = Console.ReadLine();

            Console.Write("Skriv efternamn: ");
            string? efternamn = Console.ReadLine();

            Console.Write("Skriv lön: ");
            string? lönStr = Console.ReadLine();
            int lön;
            if (!int.TryParse(lönStr, out lön)) {
                Console.WriteLine("Ogiltig lön");
                return;
            }

            if (register.LäggTill(förnamn, efternamn, lön))
                Console.WriteLine($"Ny personal tillagd ({förnamn} {efternamn})");

        }

        static void HittaPersonal()
        {

        }

        static void TaBortPersonal()
        {
            Console.Write("\nSkriv id: ");
            string? id = Console.ReadLine();
        }
    }
}
