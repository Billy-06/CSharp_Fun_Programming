using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming;

public static class CollectionSamples
{
    private static List<Customer> ourCustomers;

    public static void Queue()
    {
        var queStructure = new Queue();
        queStructure.Enqueue("First Item");
        queStructure.Enqueue("Second Item");

        string? item = null;
        Console.WriteLine("Using a Queue");
        while((item = (string?)queStructure.Dequeue()) != null)
        {
            Console.WriteLine(item);
            if (queStructure.Count <= 0) break;
        }
    }

    public static void Stack()
    {
        var stackStructure = new Stack();
        stackStructure.Push("First Item");
        stackStructure.Push("Second Item");

        string? stackItem = null;
        Console.WriteLine();
        Console.WriteLine("Using a Stack");
        while((stackItem = (string?)stackStructure.Pop()) != null)
        {
            Console.WriteLine(stackItem);
            if (stackStructure.Count <= 0) break;
        }
    }
    
    /**
     * Using a Generic Stack saves you from having to type cast 
     * in order to return the right value types
     * */
    public static void GenericStack()
    {
        var stackStructure = new Stack<string>();
        stackStructure.Push("First Item");
        stackStructure.Push("Second Item");

        string? stackItem = null;
        Console.WriteLine();
        Console.WriteLine("Using a Generic Stack");
        while((stackItem = stackStructure.Pop()) != null)
        {
            Console.WriteLine(stackItem);
            if (stackStructure.Count <= 0) break;
        }
        Console.WriteLine("\n");
    }

    public static void GenericQueue()
    {
        var queStructure = new Queue<string>();
        queStructure.Enqueue("First Item");
        queStructure.Enqueue("Second Item");

        string? item = null;
        Console.WriteLine("Using a Generic Queue");
        while ((item = queStructure.Dequeue()) != null)
        {
            Console.WriteLine(item);
            if (queStructure.Count <= 0) break;
        }
        Console.WriteLine("\n");
    }


    static CollectionSamples()
    {
        ourCustomers = new List<Customer>();
        for(int i = 1; i < 21; i++)
        {
            ourCustomers.Add(new Customer
            {
                Id = i,
                FirstName = i.ToString(),
                LastName = "Customer",
                CreateDate = new DateOnly(2022, 10, i)
            });
        }
    }

    public static void Indexing()
    {
        var customerThree = ourCustomers[2];
        Console.WriteLine($"Found customer {customerThree.Id} at Index {customerThree.Id - 1}");

        string doesContain = ourCustomers.Contains(customerThree) ? "does" : "does not";
        Console.WriteLine($"Our Customers List {doesContain} this customer");

        /**
         * TODO:
         * > What if you created a custmer with the same ID, what would happen
         * > What if the Customer was a type record or struct rather than a class
         * 
         * */
        var customerSeven = ourCustomers.Find(CustomerIsMatch);

        if (customerSeven != null)
        {
            Console.WriteLine($"Found Customer: {customerSeven.FirstName} {customerSeven.LastName} {customerSeven.Id}");
        }
        else
        {
            Console.WriteLine("No customer was found with that ID");
        }
    }

    public static bool CustomerIsMatch(Customer cust)
    {
        /**
         * TODO:
         * What if the method finds more than one match
         * */
        return cust.Id == 7;
    }

    public static void Iterating()
    {
        ourCustomers.Reverse();

        IEnumerator<Customer> customerEnumerator = ourCustomers.GetEnumerator();
        while (customerEnumerator.MoveNext())
        {
            Customer current = customerEnumerator.Current;
            Console.WriteLine($"{current.FirstName} {current.LastName}");
        }

        ourCustomers.Sort();

        foreach (var item in ourCustomers)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName}");
        }
    }

    public static void Dictionary()
    {
        Dictionary<string, Person> ourPeople = new()
        {
            {
                "Engineer",
                new Person
                {
                    FirstName = "Billy",
                    LastName = "Micah",
                    Age = 25,
                    Id = 001
                }
            },
            {
                "Instructor",
                new Person
                {
                    FirstName = "Joe",
                    LastName = "Nickson",
                    Age = 23,
                    Id = 004
                }
            }
            /**
             * TODO:
             * Try using TryAdd to accomplish safe indexing
             * 
             * */
        };

        bool keyFound = ourPeople.ContainsKey("Engineer");
        if(keyFound)
        {
            var person = ourPeople["Engineer"];
            Console.WriteLine($"Person with key 'Engineer': {person.FirstName} {person.LastName}");
        }
        /**
         * TODO:
         * Try using TryGetValue to accomplish safe indexing
         * 
         * */
        foreach (var item in ourPeople)
        {
            Console.WriteLine($"Item key: {item.Key}\tItem value: {item.Value.FirstName} {item.Value.LastName}");
        }
    }

    public static void NameValue()
    {
        var items = new NameValueCollection()
        {
            { "p", "Peter" },
            { "p", "Petro" },
            { "b", "Billy" },
            { "l", "Linette" },
            { "l", "Laban" },
            { "z", "Zeek" }
        };

        foreach (var item in items)
        {
            Console.WriteLine($"{item} {items[(string)item]}");
        }
    }
    public static void Concurrent()
    {
        // Acts like a stack in arranging the items it contains
        var personBag = new System.Collections.Concurrent.ConcurrentBag<Person>()
        {
            {
                new Person
                {
                    FirstName = "Billy",
                    LastName = "Micah",
                    Id = 002,
                    Age = 25
                }
            },{
                new Person
                {
                    FirstName = "Sherley",
                    LastName = "Micky",
                    Id = 001,
                    Age = 23
                }
            },{
                new Person
                {
                    FirstName = "Sarah",
                    LastName = "Toner",
                    Id = 003,
                    Age = 22
                }
            },{
                new Person
                {
                    FirstName = "Mwangi",
                    LastName = "WaterHouse",
                    Id = 004,
                    Age = 28
                }
            },{
                new Person
                {
                    FirstName = "Kenya",
                    LastName = "Havens",
                    Id = 005,
                    Age = 30
                }
            },
        };

        foreach (var item in personBag)
        {
            Console.WriteLine("====================");
            Console.WriteLine($"Person Id: {item.Id}\nFirst Name: {item.FirstName}\nLast Name: {item.LastName}\nAge: {item.Age}\n\n");
        }
    }

}
