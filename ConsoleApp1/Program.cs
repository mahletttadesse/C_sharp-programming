// Perform basic operations on numbers in C#

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // Mix data types to force implicit type conversions
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // Mix data types to force implicit type conversions

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second; // casting decimal on int
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}"); // modulus and interpoltion

int fahrenheit = 94;
Console.Write("The temperature is ");
Console.Write(((decimal)fahrenheit - 32) * 5 / 9);
Console.Write(" Celsius.");
