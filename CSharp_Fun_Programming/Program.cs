// See https://aka.ms/new-console-template for more information

using CSharp_Fun_Programming;

/**
 * Generic Types
 * 
 * If we try swapping value types as shown inteh code below, it fails because
 * the swap function needs a 
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


var cust = new Customer
{
    Id = 0089,
    FirstName = "Micky",
    LastName = "Jones",
    CreateDate = new DateOnly(2022, 1, 20)
};

Console.WriteLine("Customer to be Mapped onto Person");

cust.Print();
var mapper = new CustomerToPersonMapper();
var person = mapper.Map(cust);
Console.WriteLine("Person Details");
person.Print();