namespace AnimalFarm
{
    internal class Program


    {
        const int MENU_ENTER = 1;
        const int MENU_SPEAK = 2;
        const int MENU_EXIT = 3;

        const int ANIMAL_DOG = 1;
        const int ANIMAL_CAT = 2;
        const int ANIMAL_PIG = 3;
        const int ANIMAL_COW = 4;

        // number of animals currently entered 
        static int numAnimals = 0;
        // animal array
        static Animal[] animals = new Animal[100];

        static void Main(string[] args)
        {
            bool exitRequested = false;
            do
            {
                DisplayMenu();
                int userSel = GetUserSelection();
                switch (userSel)
                {
                    case MENU_ENTER:
                        ProcessAddAnimal();
                        break;

                    case MENU_SPEAK:
                        ProcessSpeak();
                        break;

                    case MENU_EXIT:
                        exitRequested = true;
                        break;

                    default:
                        Console.WriteLine("Please Make a Valid Selection");
                        break;
                }
            } while (!exitRequested);


        }
        static void DisplayMenu()
        {
            Console.WriteLine("1. Enter an Animal");
            Console.WriteLine("2. Have all animals speak");
            Console.WriteLine("3. Exit");
            Console.Write("Please make a selection: ");

        }
        static int GetUserSelection()
        {
            int userSel = int.Parse(Console.ReadLine());
            return userSel;
        }
        static void ProcessAddAnimal()
        {
            PresentAnimalMenu();
            int AnimalSel = GetAnimalSelection();
            Animal animal = null;
            switch (AnimalSel)
            {
                case ANIMAL_DOG:
                    Dog dog = new Dog();
                    animal = dog;
                    Console.Write("Enter the new dog's name: ");
                    dog.dogName(string.Format(Console.ReadLine()));
                    break;

                case ANIMAL_CAT:
                    Cat cat = new Cat();
                    animal = cat;
                    Console.Write("Enter the new cat's name: ");
                    cat.catName(string.Format(Console.ReadLine()));
                    break;

                case ANIMAL_PIG:
                    Pig pig = new Pig();
                    animal = pig;
                    Console.Write("Enter the new pig's name: ");
                    pig.pigName(string.Format(Console.ReadLine()));
                    break;

                case ANIMAL_COW:
                    Cow cow = new Cow();
                    animal = cow;
                    Console.Write("Enter the new cow's name: ");
                    cow.cowName(string.Format(Console.ReadLine()));
                    break;

            }
            animals[numAnimals++] = animal;
        }
        static void PresentAnimalMenu()
        {
            Console.WriteLine("What type of animal do you want to enter?");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Pig");
            Console.WriteLine("4. Cow");
        }
        static int GetAnimalSelection()
        {
            int animal = 0;
            do
            {
                Console.Write("Animal: ");
                animal = int.Parse(Console.ReadLine());
                if (!ValidAnimal(animal))
                    Console.WriteLine("Please select a valid animal");

            } while (!ValidAnimal(animal));
            return animal;
        }
        static bool ValidAnimal(int animal)
        {
            return (animal >= ANIMAL_DOG) && (animal <= ANIMAL_COW);
        }
        static void ProcessSpeak()
        {
            for (int i = 0; i < numAnimals; i++)
            {
                Console.WriteLine("The " + animals[i].GetAnimalName() + animals[i].Speak());
            }
        }

    }
}