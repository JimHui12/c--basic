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
if((vv + uu + ii > 10) && (a == b) ) {
    Console.WriteLine("The answer is greater than 10");
} else {
    Console.WriteLine("The answer is not greater than 10");
}


