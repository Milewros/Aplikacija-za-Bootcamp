using System.Collections.Generic;

namespace BootcampProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please write something to turn it into capital letters: ");

            UpperCaseLetters();

            SciFi scifi = new SciFi();
            Fantasy fantasy = new Fantasy();
            Numbers numbers = new Numbers();
            Characters characters = new Characters();

            scifi.Read();
            fantasy.Read();

            Console.WriteLine("A polymorph example");

            NumbersCharacters[] symbols = { numbers, characters };
            foreach (NumbersCharacters symbol in symbols)
            {
                symbol.Polymorph();
            }

            double[] doubleArray = { 1.4, 2.2, 3.6 };
            string[] stringArray = { "1", "2", "6" };
            int[] intArray = { 7, 1, 3 };

            Console.WriteLine();
            Console.WriteLine("A generics example");
            Console.WriteLine();

            Generics(doubleArray);
            Generics(stringArray);
            Generics(intArray);

            Console.WriteLine();
            Console.WriteLine("Hvala na prilici za bootcamp, nadam se da ovo ispunjava uvjete");
            Console.ReadKey();

        }
        private static void UpperCaseLetters()
        {
            bool playAgain = true;
            string player;
            string answer;
            try
            {
                while (playAgain == true)
                {
                    player = Console.ReadLine();
                    player = player.ToUpper();

                    Console.WriteLine(player);

                    Console.Write("Would you like to try again (Y/N): ");
                    answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    if (answer == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                        Console.Clear();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Try again");
            }
        }
        public static void Generics<Element>(Element[] array)
        {

            foreach (Element item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        interface Books
        {
            void Read();

        }
        class SciFi : Books
        {
            public void Read()
            {
                Console.WriteLine("I read a lot of Sci-fi books");
                Thread.Sleep(2000);
                Console.Write("Here are some of them:");

                List<string> sciFiBooks = new List<string>();

                sciFiBooks.Add("Dune, ");
                sciFiBooks.Add("Neuromancer, ");
                sciFiBooks.Add("Consider Phlebas, ");
                sciFiBooks.Add("Children of Time");

                foreach (string book in sciFiBooks)
                {
                    Console.Write(book);
                }

                Thread.Sleep(2000);
                Console.WriteLine();

            }
        }
        class Fantasy : Books
        {
            public void Read()
            {
                Console.WriteLine("I read some Fantasy books too");
                Thread.Sleep(2000);
                Console.Write("Here are also some i read: ");
                string[] fantasyBooks = { "Lord of the rings, ", "Game of thrones, ", "Harry Potter " };

                for (int i = 0; i < fantasyBooks.Length; i++)
                {
                    Console.Write(fantasyBooks[i]);
                }

                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("Press any button to continue!");
                Console.ReadKey();
                Console.Clear();
            }
        }
        class NumbersCharacters
        {
            public virtual void Polymorph()
            {

            }
        }
        class Numbers : NumbersCharacters
        {
            public override void Polymorph()
            {
                Console.WriteLine("42 27 18 168");
            }

        }
        class Characters : NumbersCharacters
        {
            public override void Polymorph()
            {
                Console.WriteLine("Yellow, Green, Black, Purple ");
            }
        }
    }
}

