using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5.Interfaces___Enum;

namespace Week5.BaseClass
{
    public abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public AnimalType Type { get; set; }

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Type = AnimalType.NotDefined;
        }

        public virtual string MakeSound()
        {
            return "not defined";
        }

        public override string ToString()
        {
            return String.Format("My name is {0}, I am {1} years old. I'am also a {2} and a {3}. I sound line this: {4}. "
                                 , this.Name, this.Age, this.Sex, this.Type, this.MakeSound());
        }       

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}

