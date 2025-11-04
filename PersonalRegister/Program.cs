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
            if (!int.TryParse(lönStr, out int lön)) {
                Console.WriteLine("Ogiltig lön");
                return;
            }

            if (register.LäggTill(förnamn, efternamn, lön))
                Console.WriteLine($"Ny personal tillagd ({förnamn} {efternamn})");
        }

        static void HittaPersonal()
        {
            Console.WriteLine("1. Hitta enstaka anställd med ID");
            Console.WriteLine("2. Hitta flera anställa med förnamn");
            Console.WriteLine("3. Hitta flera anställa med efternamnm");
            Console.WriteLine("E. Avbryt");
            string input = (Console.ReadLine() ?? "").ToUpper();

            switch (input) {
                case "1":
                    Console.Write("Skriv ID: ");
                    Personal? personal = register.HittaMedId(Console.ReadLine() ?? "");
                    if (personal is null) {
                        Console.WriteLine("Misslyckades. Personal kunde inte hittas");
                    } else {
                        Console.WriteLine($"Hittade {personal.FörNamn} {personal.EfterNamn} med lön {personal.Lön} kr");
                    }
                    break;

                case "2":
                    Console.Write("Skriv förnamn: ");
                    var personalLista = register.HittaMedNamnFörNamn(Console.ReadLine() ?? "");
                    if (personalLista.Count == 0) {
                        Console.WriteLine("Ingen hittades");
                    } else {
                        PersonalRegister.PrintRegister(personalLista);
                    }
                    break;

                case "3":
                    Console.Write("Skriv efternamn: ");
                    personalLista = register.HittaMedNamnEfterNamn(Console.ReadLine() ?? "");
                    if (personalLista.Count == 0) {
                        Console.WriteLine("Ingen hittades");
                    } else {
                        PersonalRegister.PrintRegister(personalLista);
                    }
                    break;

                case "E":
                    Console.WriteLine("Avbryter");
                    return;
            }
        }

        static void TaBortPersonal()
        {
            Console.Write("\nSkriv id: ");
            string? id = Console.ReadLine();
            
            if (register.Radera(id)) {
                Console.WriteLine($"Personal med id: {id} har tagits bort");
            }
        }
    }
}
