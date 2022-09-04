// See https://aka.ms/new-console-template for more information

using CSharp_Fun_Programming;

/**
 * Generic Types
 * 
 * Generic Types can be compared to the templates in C++ which allow us to
 * create an object/method that can be used flexibly to cater for other 
 * objects within the program.
 * 
 * 
 * */

string jsonPerson = @"{
    ""Id"": 0045,
    ""FirstName"": ""Jack"",
    ""LastName"": ""Milner"",
    ""Age"": 20,
}";

/*var pJson = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonPerson);
Console.WriteLine($"Json Person's Name: {pJson?.FirstName}, Age: {pJson?.Age}");*/

var personOne = new Person
{
    Id = 00034,
    FirstName = "Billy",
    LastName = "Micah",
    Age = 25
};


var personTwo = new Person
{
    Id = 00036,
    FirstName = "Tuesday",
    LastName = "Onoweya",
    Age = 32
};

int x = 5, y = 7;

/**
 * Examine the Code Below.
 * 
 * Using a regular swap function to swap values. Upon running the code you'll
 * notice that using the regular function fails to swap the values of the passed
 * objects and this is because we're passing, not the reference of the object but
 * the values. Values fail to persist since they are bound by the scope of the 
 * function.
 * Specifying the type object also creates conflicts in mapping onto other types.
 * 
 * Reasons regular swap function fails:
 * (a) We're using value types rather than reference types
 * (b) The function specifies that it expects type object which might
 *     make mapping onto other types diffficult.
 * 
 * 
 * Generic Type
 * > Allows for flexibility and the function can therefore be used to swap 
 *   any object type
 * > Since we're specifying the reference, it successfully changes the values
 *   because the change persists beyond the swapping scope.
 *   
 *   
 * */

static void Swap(object first, object second)
{
    (first, second) = (second, first);

}

static void GenericSwap<T>(ref T first, ref T second)
{
    (first, second) = (second, first);

}
Console.WriteLine("Before Swapping using non-Generic or Generic function");
Console.WriteLine($"X: {x}, Y: {y}");
Console.WriteLine($"Person One's Name: {personOne.FirstName}, Person Two's Name: {personTwo.FirstName}");
Console.WriteLine("\n");

Swap(personOne, personTwo);
Swap(x, y);

Console.WriteLine("After Swapping using non-Generic function");
Console.WriteLine($"X: {x}, Y: {y}");
Console.WriteLine($"Person One's Name: {personOne.FirstName}, Person Two's Name: {personTwo.FirstName}");

Console.WriteLine("\n\n");

GenericSwap<Person>(ref personOne, ref personTwo);
GenericSwap<int>(ref x, ref y);

Console.WriteLine("After Swapping using Generic function");
Console.WriteLine($"X: {x}, Y: {y}");
Console.WriteLine($"Person One's Name: {personOne.FirstName}, Person Two's Name: {personTwo.FirstName}");

Console.WriteLine("\n\n");

/**
 * Using Generic Types for Mapping Objects
 * 
 * 
 * 
 * */


var cust1 = new Customer
{
    Id = 0089,
    FirstName = "Micky",
    LastName = "Jones",
    CreateDate = new DateOnly(2022, 1, 20)
};

var cust2 = new Customer
{
    Id = 0040,
    FirstName = "Micky",
    LastName = "Jones",
    CreateDate = new DateOnly(2022, 1, 20)
};

var cust3 = new Customer
{
    Id = 0459,
    FirstName = "Micky",
    LastName = "Jones",
    CreateDate = new DateOnly(2022, 1, 20)
};

var cust4 = new Customer
{
    Id = 0049,
    FirstName = "Micky",
    LastName = "Jones",
    CreateDate = new DateOnly(2022, 1, 20)
};

Console.WriteLine("Customer to be Mapped onto Person");

cust1.Print();
var mapper = new CustomerToPersonMapper();
var person = mapper.Map(cust1);
Console.WriteLine("Person Details");
person.Print();

Console.WriteLine("Using the Sorter Object");
var sorter = new Sorter<Customer>();
var customerList = new Customer[] { cust1, cust2, cust3, cust4 };

sorter.BeginSort(customerList);