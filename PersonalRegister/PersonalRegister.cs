using System;
using System.Collections.Generic;
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

        public void Add(Personal p)
        {
            register.Add(p);
            AntalAnställda++;
        }

        public void Delete(string id)
        {
            AntalAnställda--;
        }

        public void PrintRegister()
        {
            Console.WriteLine($"Skriver ut info för {AntalAnställda} anställda.");
            foreach (var p in register) {
                p.SkrivPersonalInfo();   
            }
        }
    }
}
