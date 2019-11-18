using System;

namespace ClassAnimal
{
    class Animal
    {
        public string name;
        public double weight;
        public double age;
        public double lifespan;
    
        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Age: {age}");
        }
        public void Age()
        {
            age++;
        }
    }
    class Hamster : Animal
    {
        public void Eat()
        {
            Console.WriteLine("NomNom");
            weight += 0.2;
        }
        public void Exercise()
        {
            Console.WriteLine("Run");
            weight -= 0.1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.Create a class Animal that has got the following attributes:
             - name
             - weight
             - lifespan(0 by default)
             2. inside the class, create methods:
             - to display the base information about the animal
             - to display lifespan
             - to display weight
             - to make the animal eat and gain weight(+ 0.2 with every food intake)
             - to make the animal exercise and lose weight(-0.1 with every run)
             2. Create an object hamster, give it a name and the weight
             3. Make your hamster live ten cycles(using the for-loop), inside this for-loop, do not forget to feed your hamster
             4. Once your hamster's weight reaches the point of 0.7, make him run to lose some weight to get it back to normal (let's assume that 0.7 is the normal weight).
             5. Once the cycle of 10 rounds is over the hamster dies (I'm sorry, we can't help it).*/

            Hamster hamster = new Hamster();
            hamster.name = "Liisu";
            hamster.weight = 0.2;
            hamster.age = 0;
            hamster.lifespan = 0;

            hamster.PrintAnimalBaseInfo();

            for(hamster.lifespan = 0; hamster.lifespan < 10; hamster.lifespan++)
            {
                if (hamster.weight < 0.7)
                {
                    hamster.Eat();
                    Console.WriteLine($"Hamster gains weight {hamster.weight}");
                }
                else if (hamster.weight > 0.7)
                {
                    hamster.Exercise();
                    Console.WriteLine($"Hamster looses weight {hamster.weight}");
                }
                hamster.Age();
            }

            Console.WriteLine($"Our lovely hamster dies.");
            hamster.PrintAnimalBaseInfo();
        }
    }
}
