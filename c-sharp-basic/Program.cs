// See https://aka.ms/new-console-template for more information
/*
String
*/
using System.Diagnostics.Metrics;

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
// long c = checked(a + b);
// Console.WriteLine(c);

double aa = 42.1;
decimal fjk = 34.2M; // explicit type
decimal decimalTwo = 39.2M;
float cc = 38.2F;
// long ddd = checked(a+b);
double abc = aa + cc;
Console.WriteLine(abc);
Console.WriteLine($"The answer is {fjk}" + fjk);
Console.WriteLine($"The answer is {decimalTwo}" + decimalTwo);

/*
If condition
*/
int an = 5;
int bn = 6;
int hj = an + bn;
bool mytest = hj > 10;
if (mytest)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}

int vv = 4;
int uu = 4;
int ii = 3;
// && operation
if ((vv + uu + ii > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}

/*
while, do while loops
*/
int counter = 0;
while (counter < 5)
{
    counter++;
    Console.WriteLine(counter);
}

counter = counter + 1;
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);

do
{
    Console.WriteLine(counter);
    counter++;
}
while (counter < 5);


/*
 for loops
*/
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

for (int row = 0; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}), ({column})");
    }
}

/*
List  Cup<T>
*/
// var name = "Scott";
// var name = 3F;
var names = new List<string> {"Scott", "Ana", "Felipe"};
names.Add("David");
names.Add("Damian");
names.Add("Maria");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine(names[0]);
Console.WriteLine(names[2]);
Console.WriteLine(names[^1]);
Console.WriteLine(names[^2]);

/*
Arrays
Arrays are fixed in length, fixed memory
*/
var manyNames = new string[] {"Scott", "Anna", "Felipe"};
manyNames = [..manyNames, "Damian"];
foreach (var name in manyNames)
{
    Console.WriteLine($"Hello {name.ToUpper()}!1");
}


