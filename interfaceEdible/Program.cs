using System;

namespace interfaceEdible
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dong vat
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if(animal is Chicken)
                {
                    Edible edible = (Chicken)animal;
                    Console.WriteLine(edible.HowToEat());
                }
            }

            //Trai cay
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
        }
    }
}
