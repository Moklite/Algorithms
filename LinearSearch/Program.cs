using System;
using System.Linq;

namespace LinearSearch
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}", Name, Age);
        }
    }
    class Program
    {
        /// <summary>
        /// Used to search values in int array 
        /// </summary>
        /// <param name="collection"> the collection that the search is going to be executed on</param>
        /// <param name="itemToSearch"> the integer value to search for in the collection</param>
        /// <returns>the index of the searched item. returns -1 if not found</returns>
        static int Search(int[] collection, int itemToSearch)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == itemToSearch)
                {
                    return i;
                }
                
            }
            return -1;
        }
        static Person FindPersonByName(Person[] people, string nameToSearch)
        {
            foreach(var person in people)
            {
                if(person.Name == nameToSearch)
                {
                    return person;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            int[] collection = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("The collection");
            for (int i = 0; i < collection.Length; i++)
            {
                Console.Write(collection[i] + ", ");
            }
            Console.WriteLine();

            Console.Write("Type a number you are looking for: ");
            int numberToSearch = int.Parse(Console.ReadLine());
            Console.WriteLine("Searching item {0} in the collection...", numberToSearch);
            int searchResult = Search(collection, numberToSearch);
            if(searchResult != -1)
            {
                Console.WriteLine("The value has been found at index {0}", searchResult);
            }
            else
            {
                Console.WriteLine("The value could not be found in the collection");
            }


            Person[] people =
            {
                new Person
                {
                    Name = "Abbey",
                    Age = 31
                },
                new Person
                {
                    Name = "Ayomide",
                    Age = 21
                },
                new Person
                {
                    Name = "Shade",
                    Age = 18
                },
                new Person
                {
                    Name = "Tobi",
                    Age = 12
                },
                new Person
                {
                    Name = "Blessing",
                    Age = 16
                }
            };

            people.ToList().ForEach(x => Console.WriteLine(x));

            Console.Write("Type a name you are looking for: ");
            string nameToFind = Console.ReadLine();
            Person resultOfSearch = FindPersonByName(people, nameToFind);

            Console.WriteLine("\nSearch for {0} in the database.", nameToFind);

            if (resultOfSearch != null)
            {
                Console.WriteLine("The name {0} has been found", resultOfSearch.Name);
            }
            else
            {
                Console.WriteLine("Sorry {0} could not be found in the database!!!", nameToFind);
            }

            Console.ReadLine();
        }
    }
}
