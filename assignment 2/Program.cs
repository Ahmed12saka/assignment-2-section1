Console.Write("Enter the amount you want to convert from liters to gallons: ");
int liters = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the amount you want to convert from gallons to liter");
int gallons = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Gallons = {liters * 1 / 3.78}");
Console.WriteLine($"liters = {gallons * 3.78 / 1}");