using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming;

public class Person : IComparable<Person>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person? other)
    {
        /**
             * Implement the interface for object comparison
             * 
             * */

        if (other?.Id == this.Id)
        {
            return 0;
        }
        if (other?.Id > this.Id)
        {
            return -1;
        }
        return 1; ;
    }

    public override string ToString()
    {
        return $"\nCustomer Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nDate Created: {Age}\n";
    }

    public void Print()
    {
        Console.WriteLine($"\nPerson Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\n");
    }
}
