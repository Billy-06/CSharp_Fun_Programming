using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public void Print()
    {
        Console.WriteLine($"\nPerson Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\n");
    }
}
