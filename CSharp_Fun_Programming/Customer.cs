using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming;

/**
 * <summary>
 * This is a Customer Class with  four public fields
 * 
 * </summary>
 * 
 * */

public class Customer : IComparable<Customer>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly CreateDate { get; set; }

    public int CompareTo(Customer? other)
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
        return 1;
    }

    public override string ToString()
    { 
        return $"\nCustomer Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nDate Created: {CreateDate}\n";
    }

    public void Print()
    {
        Console.WriteLine($"\nCustomer Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nDate Created: {CreateDate}\n");
    }
}
