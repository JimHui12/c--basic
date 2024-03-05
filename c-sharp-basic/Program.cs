// See https://aka.ms/new-console-template for more information
/*
String
*/
using System.Diagnostics.Metrics;
using System.Globalization;

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
var names = new List<string> { "Scott", "Ana", "Felipe" };
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
var manyNames = new string[] { "Scott", "Anna", "Felipe" };
manyNames = [.. manyNames, "Damian"];
foreach (var name in manyNames)
{
    Console.WriteLine($"Hello {name.ToUpper()}!1");
}

/*
Sorting and Searching List
*/
var nameList = new List<string> { "Abc", "Bac", "Cba" };
var numberList = new List<int> { 46, 48, 88, 99, 67, 78, 41 };

nameList.Sort();

numberList.Sort();

Console.WriteLine($"I found 99 at index {numberList.IndexOf(99)}");


// foreach (var name in nameList)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

// foreach(var number in numberList)
// {
//     Console.WriteLine($"{number}");
// }

/**
Language Integrated Query (LINQ) and IEnumerable
*/
List<int> scores = [3, 20, 100, 99, 92, 81, 50, 66];
scores.Sort();
// for (int i = 0; i < scores.Count; i++) {
//     if(scores[i] > 80)
//     {
//         Console.WriteLine($"Found a score over 80 {scores[i]}");
//     }
// }

// return;

// Define the query expression.
// IEnumerable<string> scoreQuery =
//     from score in scores
//     where score > 80
//     orderby score descending
//     select $"The score is {score}";

// // Execute the query.
// foreach (string s in scoreQuery)
// {
//     Console.WriteLine(s);
// }

/**
LINQ Method Syntax vs Query
**/
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

var scoreQuery2 = scores.Where(s => s > 80).OrderByDescending(s => s);
List<int> myScores = scoreQuery.ToList();

foreach (var score in myScores)
{
    Console.WriteLine(score);
}


/*
OOP
*/

Console.WriteLine("Hello OOP");
var p1 = new Person("Scott", "Hanselman", new DateOnly(1970, 1, 1));
var p2 = new Person("David", "Taylor", new DateOnly(1970, 1, 1));

p1.Pets.Add(new Dog("max"));
p1.Pets.Add(new Dog("barney"));
p2.Pets.Add(new Cat("Linh"));
p2.Pets.Add(new Cat("Lucy"));

List<Person> people = [p1, p2];

Console.WriteLine(people.Count);

foreach(var person in people)
{

    Console.WriteLine($"{person} ");
    foreach(var pet in person.Pets)
    {
        Console.WriteLine( $"    has a {pet}");
    }
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string Frist {get;  } = firstName;
    public string Last {get;  } = lastName;
    public DateOnly Birthdya {get;} = birthday;

    public List<Pet> Pets {get;} = new();
    public override string ToString()
    {
        return $"{Frist} {Last}";
    }
}

public abstract class Pet(string firstName) 
{
    public string First {get;} = firstName;
    public abstract string MakeNoise();
        public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()} ";
    }
}

public class Cat(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "meow";
    
}

public class Dog(string firstName) : Pet(firstName)
{
    public override string MakeNoise() => "bark";
    
}










