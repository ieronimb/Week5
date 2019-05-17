using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5.BaseClass;
using Week5.DerivedClasses;
using Week5.Interfaces___Enum;
using Week5.TransitiveClasses;

namespace Week5Part1Ex2
{
    class Program
    {                          
        static void Main(string[] args)
        {
            //2.Animal hierarchy
            //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.Dogs, frogs and cats are Animals.
            //All animals can produce sound(specified by the ISound interface). Kittens and tomcats are cats.All animals are described by 
            //age, name and sex.
            //Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
            //Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method(you may use LINQ).

            //Cat list
            Console.WriteLine("1) The cat list is:\n");
            var cat = new List<Cat>()
            { new Cat("Fluffy", 10,Gender.Female),
              new Cat("Tom", 4,Gender.Male),
              new Cat("Kurt", 3,Gender.Male),
              new Cat("Lia", 7,Gender.Female)
            };
            foreach (var item in cat)
            {
                Console.WriteLine(">" + item);
            }
            Console.WriteLine($"The average age of the above cats is {Animal.AverageAge(cat)} years.");

            //Dog list
            Console.WriteLine("\n2) The dog list is:\n");
            var dog = new List<Dog>()
            { new Dog("Lia", 4, Gender.Female),
              new Dog("Spot", 5,Gender.Male),
              new Dog("Oldy", 15,Gender.Male),
              new Dog("Kira", 3, Gender.Female)
            };
            foreach (var item in dog)
            {
                Console.WriteLine(">" + item);
            }
            Console.WriteLine($"The average age of the above dogs is {Animal.AverageAge(dog)} years.");

            //Frog list
            Console.WriteLine("\n3) The frog list is:\n");
            var frog = new List<Frog> ()
            { new Frog("Gronky", 2, Gender.Male),
              new Frog("Loudy", 5, Gender.Male),
              new Frog("Shinny", 3, Gender.Female),
              new Frog("Spiky", 1, Gender.Female)
            };
            foreach (var animals in frog)
            {
                Console.WriteLine(">" + animals);
            }
            Console.WriteLine($"The average age of the above frogs is {Animal.AverageAge(frog)} years.");

            //Kitten list
            Console.WriteLine("\n4) The kitten list is:\n");
            var kitten = new List<Kitten>()
            { new Kitten("Diana", 1),
              new Kitten("Mercury", 2),
              new Kitten("Jane", 2),
              new Kitten("Leea", 1)
            };
            foreach (var animals in kitten)
            {
                Console.WriteLine(">" + animals);
            }
            Console.WriteLine($"The average age of the above kittens is {Animal.AverageAge(kitten)} years.");

            //Tomcat list
            Console.WriteLine("\n4) The tomcat list is:\n");
            var tomcat = new List<Tomcat>()
            { new Tomcat("Newby", 2),
              new Tomcat("Timny", 1),
              new Tomcat("Goody", 3),
              new Tomcat("Lee", 5)
            };
            foreach (var animals in tomcat)
            {
                Console.WriteLine(">" + animals);
            }
            Console.WriteLine($"The average age of the above kittens is {Animal.AverageAge(tomcat)} years.");

            Console.ReadLine();             
        }
    }
}
