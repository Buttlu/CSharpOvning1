namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            do {
                Console.WriteLine("Personalregister");
                Console.WriteLine("1. Lägg till ny anställd");
                Console.WriteLine("2. Hitta en viss anställd");
                Console.WriteLine("3. Se antalet anställda");
                Console.WriteLine("4. Ta bort en viss anställd");
                Console.WriteLine("E. Avsluta Applikationen");
                input = Console.ReadLine() ?? "";
                input = input.ToUpper();

                switch (input) {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid inputm, please try again");
                        continue;
                    case "E":
                        break;
                }

            } while (input != "E");
        }
    }
}
