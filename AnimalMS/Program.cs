using System;
using System.Collections;

namespace AnimalMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();
            Cat c = new Cat();
            int choice;
            Console.WriteLine("1. Create a Crocodile");
            Console.WriteLine("2. Create a Cat");
            Console.WriteLine("3. Create a Fish");
            Console.WriteLine("4. View Terrestrial Animals");
            Console.WriteLine("5. View Marine Animals");
            Console.WriteLine("6. View all Animals");
            Console.WriteLine("7. Delete Animal");
            Console.WriteLine("8. Exit");

            do
            {
                Console.WriteLine("\nPlease select an item: ");
                int.TryParse (Console.ReadLine(), out choice);
                switch (choice)
                {
                  case 1: t.AddCrocodile();
                  break;

                  case 2: t.AddCat();
                  break;

                  case 3: t.AddFish();
                  break;

                  case 4: t.ViewTerrestrialAnimals();
                  break;

                  case 5: t.ViewMarineAnimals();
                  break;

                  case 6: t.ViewAllAnimals();
                  break;

                  case 7: t.DeleteAnimals();
                  break;

                  case 8: return;
                }
            } while(choice !=8);

        }


        int count = 0;
        Hashtable ListAnimal = new Hashtable();
        private object i;

        public void AddCat()
        {
            Cat obj = new Cat();
            obj.ID = count;
            Console.WriteLine("Ten cua Cat: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Tuoi cua Cat: ");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }

        public void AddFish()
        {
            Fish obj = new Fish();
            obj.ID = count;
            Console.WriteLine("Ten cua Fish: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Tuoi cua Fish: ");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }

        public void AddCrocodile()
        {
            Crocodile obj = new Crocodile();
            obj.ID = count;
            Console.WriteLine("Ten cua Crocodile: ");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Tuoi cua Crocodile: ");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void ViewTerrestrialAnimals()
        {
            Cat c = new Cat();
            for (int i =0; i < ListAnimal.Count; i++)
                if (ListAnimal[i].GetType().Equals(c.GetType()))
                {
                    ListAnimal[i].ToString();
                    c.Move();
                }
        }
        public void ViewMarineAnimals()
        {
            Fish f = new Fish();
            for (int i =0; i < ListAnimal.Count; i++)
                if (ListAnimal[i].GetType().Equals(f.GetType()))
                {
                    ListAnimal[i].ToString();
                    f.Move();
                }
        }

        public void ViewAllAnimals()
        {
            foreach (DictionaryEntry de in ListAnimal.Values)Console.WriteLine(de);
        }
        public void DeleteAnimals()
        {
            int n;
            Console.WriteLine("Vui long chon mot chia khoa: ");
            int.TryParse(Console.ReadLine(), out n);
            foreach(DictionaryEntry de in ListAnimal)
                if (de.Key.Equals(n))
                {
                    ListAnimal.Remove(n);
                    break;
                }
            Console.WriteLine(ListAnimal.Count);
        }
    }
}
