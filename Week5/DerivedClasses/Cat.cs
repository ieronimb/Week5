using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5.BaseClass;
using Week5.Interfaces___Enum;

namespace Week5.DerivedClasses
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender sex): base(name, age, sex)
        {
            this.Type = AnimalType.Cat;
        }

        public override string MakeSound()
        {
            return "miau";
        }
    }
}
