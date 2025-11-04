using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
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

        public void LäggTill(Personal p)
        {
            register.Add(p);
            AntalAnställda++;
        }

        public void Radera(string id)
        {
            Personal? p = register.Find(p => p.Id == id);
            if (p is null) {
                Console.WriteLine($"Anställd med id \"{id}\" kunde inte hittas.");
                return;
            }
            register.Remove(p);
            AntalAnställda--;
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
    }
}
