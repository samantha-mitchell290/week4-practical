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
