using System.Diagnostics.CodeAnalysis;
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

/* for(int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
{
    Console.WriteLine(carManufacturers[5]);
}
*/
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
