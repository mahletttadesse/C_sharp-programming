// Perform basic string formatting in C#

Console.WriteLine("Hello\tWorld!"); // tab
Console.WriteLine("Hello\nWorld!"); // new line
Console.WriteLine("Hello \"World\"!"); // unescape

// Putting it all together
Console.WriteLine("\nGenerating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices"); // verbatim string litral
Console.Write('\n'); // new line as a char

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// string concatenation 

string firstName = "Bob";
string message = "Hello " + firstName; // no space and !
Console.Write('\n');
Console.WriteLine(message);
string greeting = "Hello ";
Console.WriteLine(greeting + " " + firstName + "!"); // with space and !, inside console

// Combine strings using string interpolation

message = $"{greeting} {firstName}!"; // interpolation
Console.WriteLine(message);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
Console.Write('\n');
// Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.

projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
    c:\Exercise\{projectName}\data.txt" + '\n');
Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt");