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

        public PersonalRegister()
        {
            register = new();
        }

        public void Add(Personal p)
        {
            register.Add(p);
        }
    }
}
