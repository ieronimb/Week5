using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5.DerivedClasses;
using Week5.Interfaces___Enum;

namespace Week5.TransitiveClasses
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Gender.Male)
        {

        }
    }
}
