// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstFriend = "Maria";
string secondFriend = "Sage";

Console.WriteLine($"{firstFriend} and {secondFriend}");

string greeting = "    Maria   ";
greeting = greeting.TrimStart();
greeting = greeting.Trim();
string greetingTwo = "   scoat      ";
Console.WriteLine($"{greeting} and {greetingTwo.Trim()}");