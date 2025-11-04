namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            PersonalRegister register = new();

            Console.WriteLine("Personalregister\n");
            do {
                Console.WriteLine("1. Lägg till ny anställd");
                Console.WriteLine("2. Hitta en viss anställd");
                Console.WriteLine("3. Se antalet anställda");
                Console.WriteLine("4. Ta bort en viss anställd");
                Console.WriteLine("E. Avsluta Applikationen");
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
                        TaBortPersonal();
                        break;
                    default:
                        Console.WriteLine("Invalid inputm, please try again");
                        continue;
                    case "E":
                        break;
                }

                Console.WriteLine("\nKlicka någon tangent för fortsätta");
                Console.ReadLine();
                Console.Clear();
            } while (input != "E");
        }

        static void LäggTillNyPersonal()
        {

        }

        static void HittaPersonal()
        {

        }

        static void TaBortPersonal()
        {

        }
    }
}
