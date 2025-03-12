string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);
string message = $"{greeting} {firstName}!";
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
// i learned that string concatenation allows you to combine smaller literal and variable strings into a single string.
