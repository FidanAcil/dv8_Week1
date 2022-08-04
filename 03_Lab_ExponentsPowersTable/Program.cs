//01_Week : 03_Lab : Exponents / Powers Table

Console.WriteLine("Welcome to Grand Circus` Exponents/Powers Table!");
Console.WriteLine("***********************************************");
Console.WriteLine();

bool keepGoing = true;

while (keepGoing)
{
    Console.Write("Please, input the number:  "); //assuming users input an integer number
    int number = Convert.ToInt32(Console.ReadLine());
    
    long numCubed = (long)number * (long)number * (long)number;
    Console.WriteLine();

    if (number > 0 && numCubed < int.MaxValue)
    {
        // right - aligning
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
        Console.WriteLine("======\t\t\t=======\t\t\t======");

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(String.Format("{0, 6}{1, 25}{2, 23}", i, i*i, i*i*i));
           
        }
        Console.WriteLine("-------------------------------------------------------");
    }
    else
    {
        Console.WriteLine("The input number {0} is not valid!:  ", number);
    }

    Console.Write("\nWould you like to go again? (y/n):  ");

    string entry = Console.ReadLine().ToLower();

    if (entry == "y" || entry == "yes")
    {
        keepGoing = true;
    }
    else  // no 
    {
        keepGoing = false;
    }
    Console.WriteLine();   
}

Console.WriteLine("\n All done, thank you for using this program!!");
