using System.Diagnostics.CodeAnalysis;
using Week4Practical;
//Challenge 1

string[] carManufacturers = { "Ford", "Toyota", "BMV", "Honda" };

foreach (var car in carManufacturers)
{
    Console.WriteLine(car);
}

Console.WriteLine(" ");

Array.Sort(carManufacturers);

foreach (var car in carManufacturers)
{
    Console.WriteLine(car);
}

//accessing an invalid carManufacturers index
//Challenge 4
try
{
    for(int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
    {
        Console.WriteLine(carManufacturers[carIndex]);
    }
}
catch (Exception)
{
    Console.WriteLine("Error: Attempted to access an array index that does not exist");
}
finally
{
    Console.WriteLine("Array processing complete");
}
 


Console.WriteLine(" ");


//Challenge 2

List<string> months = new List<string>();
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

months.Remove("September");
months.Remove("November");

Console.WriteLine(months.Count);
Console.WriteLine("The index of 'December' is:" + months.IndexOf("December"));

string[] monthNamesArray = months.ToArray();

Console.WriteLine(" ");

//Challenge 3

Dictionary<string, int> inventory = new Dictionary<string, int>();
inventory.Add("Health potion", 5);
inventory.Add("Mana potion", 2);
inventory.Add("Gold coin", 100);

inventory["Health potion"] = 20;
Console.WriteLine(inventory["Health potion"]);

//Accessing a key that is invalid
//Challenge 4
try
{
    Console.WriteLine(inventory["Iron sword"]);
}
catch (Exception)
{
    Console.WriteLine("Error: Item not found in inventory");
}
finally
{
    Console.WriteLine("Dictionary processing complete");
}

Console.WriteLine(" ");

//Challenge 5

Student student1 = new Student(1, "Alice Smith", 20);

List<Student> student = new List<Student>();
student.Add(student1);

Student student2 = student1;

student2.Age = 99;

student1.Display();