
//Console.WriteLine("what is your name");
//string entry = Console.ReadLine();
//Console.WriteLine($"great to meet you, {entry}");

Console.WriteLine("enter a number");
string entry = Console.ReadLine();
int n = int.Parse(entry);
//int n = Convert.ToInt32(entry);


if (n > 50)
{
    Console.WriteLine("yes, n is greater than 50");
    Console.WriteLine($"n is {n}");
    Console.WriteLine("n is {0}", n);
    Console.WriteLine($"n is {n * 2}");
}
else
{
    Console.WriteLine("n is not");
    Console.WriteLine($"n is {n}");
}

// Let`s see if the number between 3 and 10 exclusive

if ((n > 3) && (n < 10))
{
    Console.WriteLine("yes, n is between 3 and 10 exclusive");
}
else
{
    Console.WriteLine("no, n is not betwwe 3 and 10 exclusive");
}

// Let`s see if the number between 3 and 10 inclusive

if ((n >= 3) && (n <= 10))
{
    Console.WriteLine("yes, n is between 3 and 10 inclusive");
}
else
{
    Console.WriteLine("no, n is not betwwe 3 and 10 inclusive");
}