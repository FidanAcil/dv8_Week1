int n = 1;

if (n == 0)
{
    Console.WriteLine("zero");
}
else if (n == 1)
{
    Console.WriteLine("one");
}
else if (n == 2)
{
    Console.WriteLine("two");
}
else
{
    Console.WriteLine("not sure!");
}

// SWITCH

switch (n)
{
    case 0:
        Console.WriteLine("zero");
        break;
    case 1:
        Console.WriteLine("one");
        break;
    case 2:
    case 3:
    case 4:
        Console.WriteLine("either two or three or four");
        break;
    default:
        Console.WriteLine("not sure");
        break;

}