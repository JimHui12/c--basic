// See https://aka.ms/new-console-template for more information
/*
String
*/
Console.WriteLine("Hello, World!");
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"{firstFriend} and {secondFriend}");
string greeting = "    Maria   ";
greeting = greeting.TrimStart();
greeting = greeting.Trim();
string greetingTwo = "   Scoat   Scott   ";
string friends = $"{greeting} and {greetingTwo.Trim()}";
Console.WriteLine(friends);
friends = friends.Replace("Scott", "Damian");
Console.WriteLine(friends);
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.StartsWith("Sco"));

/*
Integer
*/
int a = 2100000000;
int b = 2100000000;
// long c = (long)a + (long)b;
long c = checked(a + b);
Console.WriteLine(c);