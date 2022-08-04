// 01_Week : 02_Lab : Number Analyzer - Decision Maker

Console.WriteLine("Welcome to Grand Circus` Decision Maker!");
Console.WriteLine("***********************************************");

bool keepGoing = true;

while (keepGoing)  // the program continue to keep going until they want to stop!
{
    Console.WriteLine();
    Console.Write("Please, input an integer number between 1 and 100:  ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (number >= 1 && number <= 100)  //or (number > 0 && number < 101)
    {
        Console.WriteLine("The number {0} is valid, here to go!\n", number);
        //Console.WriteLine();

        if (number % 2 == 0)   // even number
        {
            if (number > 1 && number < 25)  //or if (number >= 2 && number <= 24)
            {
                Console.WriteLine("The number {0} is Even and less than 25", number);
            }
            else if (number >= 26 && number <= 60)
            {
                Console.WriteLine("The number {0} is Even and between 26 and 60", number);
            }
            else if (number > 60)
            {
                Console.WriteLine("The number {0} is Even and greater than 60", number);
            }
        }
        else      // odd number
        {
            if (number < 60)
            {
                Console.WriteLine("The number {0} is Odd and less than 60 ", number);
            }
            else if (number > 60)
            {
                Console.WriteLine("The number {0} is Odd and greater than 60", number);
            }
        }
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
    else  // no or any invalid input (avoid everything except yes: such as string, character, numbers etc..)
    {
        keepGoing = false;
    }
}

Console.WriteLine("\nThank you for using this program!!");

