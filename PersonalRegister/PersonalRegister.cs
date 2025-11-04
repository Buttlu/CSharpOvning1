using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class PersonalRegister
    {
        List<Personal> register;
        public int AntalAnställda { get; private set; }

        public PersonalRegister()
        {
            register = new();
        }

        public bool LäggTill(string förNamn, string efterNamn, int lön)
        {
            if (förNamn is null || förNamn == string.Empty) {
                Console.WriteLine("Misslyckades. Felaktigt förnamn");
                return false;
            } else if (efterNamn is null || efterNamn == string.Empty) {
                Console.WriteLine("Misslyckades. Felaktigt efrternamn");
                return false;
            } else if (lön < 0) {
                Console.WriteLine("Misslyckades. Lönen är negativ");
                return false;
            }

            register.Add(new Personal(förNamn, efterNamn, lön));
            AntalAnställda++;
            return true;
        }

        public bool LäggTill(Personal p)
        {
            if (p is null)
                return false;

            register.Add(p);
            AntalAnställda++;
            return true;
        }

        public bool Radera(string id)
        {
            Personal? p = register.Find(p => p.Id == id);
            if (p is null) {
                Console.WriteLine($"Anställd med id \"{id}\" kunde inte hittas.");
                return false;
            }
            register.Remove(p);
            AntalAnställda--;
            return true;
        }

        public Personal? HittaMedId(string id) => register.First(p => p.Id == id);
        public List<Personal> HittaMedNamnFörNamn(string förNamn) => register.Where(p => p.FörNamn == förNamn).ToList();
        public List<Personal> HittaMedNamnEfterNamn(string efterNamn) => register.Where(p => p.EfterNamn == efterNamn).ToList();

        public void PrintRegister()
        {
            Console.WriteLine($"Skriver ut info för {AntalAnställda} anställda.");
            foreach (var p in register) {
                p.SkrivPersonalInfo();   
            }
        }

        public static void PrintRegister(List<Personal> register)
        {
            Console.WriteLine($"Skriver ut info för {register.Count} anställda.");
            foreach (var p in register) {
                p.SkrivPersonalInfo();
            }
        }
    }
}
