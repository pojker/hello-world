// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine("Hello " + aFriend);

aFriend = "Maira";
Console.WriteLine("Hello " + aFriend);

Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "    Hello World!    ";
string trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

# Trim start and end:
# string trimmedGreeting = greeting.TrimStart();
# Console.WriteLine($"[{trimmedGreeting}]");
#
# trimmedGreeting = greeting.TrimEnd();
# Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);