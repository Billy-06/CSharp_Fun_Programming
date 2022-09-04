using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly CreateDate { get; set; }

        public void Print()
        {
            Console.WriteLine($"\nCustomer Id: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nDate Created: {CreateDate}\n");
        }
    }
}
