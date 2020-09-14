using GenericCollections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person()
                {
                    Id = 1,
                    Firstname = "John",
                    Lastname = "Smith"
                },
                new Person()
                {
                    Id = 2,
                    Firstname = "Angel",
                    Lastname = "Baker"
                }
            };

            Array.Resize(ref persons, 10);

            persons[2] = new Person()
            {
                Id = 3,
                Firstname = "Mark",
                Lastname = "Tan"
            };

            //Resizing array can be difficult and too much code to write, especially there is a performance hit on this occassion

            List<Person> listPersons = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Firstname = "John",
                    Lastname = "Smith"
                },
                new Person()
                {
                    Id = 2,
                    Firstname = "Angel",
                    Lastname = "Baker"
                }
            };

            //Advantages of List of T Data Structure - Can easily insert new items and list automatically grows by double in capacity without creating an entirely new list object


            //If you want to retrieve items using LIFO
            Queue<Person> queuePersons = new Queue<Person>();

            queuePersons.Enqueue(new Person()
            {
                Id = 1,
                Firstname = "John",
                Lastname = "Smith"
            });

            queuePersons.Enqueue(new Person()
            {
                Id = 2,
                Firstname = "Angel",
                Lastname = "Baker"
            });

            //To peek on item without removing it permanently:
            var queuePeek = queuePersons.Peek();


            //If you want to retrieve items using FIFO
            Stack<Person> stackPersons = new Stack<Person>();
            stackPersons.Push(new Person()
            {
                Id = 1,
                Firstname = "John",
                Lastname = "Smith"
            });


            stackPersons.Push(new Person()
            {
                Id = 2,
                Firstname = "Angel",
                Lastname = "Baker"
            });

            //HashSet is a datastructure which means all items are unique. You can implement this if you want your datastructure to be unique
            //Example would be a list of section in your school directory where you need to implement unique items of students.

            HashSet<int> hashSetOfInts = new HashSet<int>();
            hashSetOfInts.Add(1);
            hashSetOfInts.Add(2);
            hashSetOfInts.Add(3);

            HashSet<Person> hashSetPersons = new HashSet<Person>(new PersonComparer());
            hashSetPersons.Add(new Person()
            {
                Id = 1,
                Firstname = "John",
                Lastname = "Smith"
            });

            hashSetPersons.Add(new Person()
            {
                Id = 1,
                Firstname = "John",
                Lastname = "Smith"
            });

            foreach (var item in hashSetPersons)
            {
                //Console.WriteLine(string.Format("HashSet for reference Persons: {0}", item.Id));
            }

            Dictionary<string, List<Person>> dictPersons = new Dictionary<string, List<Person>>();

            dictPersons.Add("Engineering", new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Firstname = "John",
                    Lastname = "Smith"
                }
            });

            dictPersons["Engineering"].Add(new Person()
            {
                Id = 2,
                Firstname = "Angel",
                Lastname = "Baker"
            });

            //To add additional key value pair:

            dictPersons.Add("HR", new List<Person>()
            {
                new Person()
                {
                    Id = 3,
                    Firstname = "Michael",
                    Lastname = "Malone"
                }
            });

            dictPersons["HR"].Add(new Person()
            {
                Id = 4,
                Firstname = "Kyle",
                Lastname = "Tucker"
            });

            //To print the list
            foreach (var item in dictPersons)
            {
                Console.WriteLine($"Department: {item.Key}");
                Console.WriteLine($"\t Employee: ");
                foreach (var listItem in item.Value)
                {
                    Console.WriteLine($"\t \t {listItem.Firstname}");
                }
            }

            SortedDictionary<string, List<Person>> dictSortedPersons = new SortedDictionary<string, List<Person>>();

            dictSortedPersons.Add("Engineering", new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Firstname = "John",
                    Lastname = "Smith"
                }
            });

            dictSortedPersons["Engineering"].Add(new Person()
            {
                Id = 2,
                Firstname = "Angel",
                Lastname = "Baker"
            });

            //To add additional key value pair:

            dictSortedPersons.Add("Accounting", new List<Person>()
            {
                new Person()
                {
                    Id = 3,
                    Firstname = "Michael",
                    Lastname = "Malone"
                }
            });

            dictSortedPersons["Accounting"].Add(new Person()
            {
                Id = 4,
                Firstname = "Kyle",
                Lastname = "Tucker"
            });

            //To print the list
            foreach (var item in dictSortedPersons)
            {
                Console.WriteLine($"Department: {item.Key}");
                Console.WriteLine($"\t Employee: ");
                foreach (var listItem in item.Value)
                {
                    Console.WriteLine($"\t \t {listItem.Firstname}");
                }
            }

            Console.ReadLine();

        }
    }
}
