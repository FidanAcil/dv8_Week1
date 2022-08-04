/* Instructions:
 Ask the user to enter a number
 Print out the square of the number
 Ask the user if they want to go again.
 They can enter y or Y to go again, n or N to quit. */

//Console.WriteLine("pls enter a number");
//double num1 = Convert.ToDouble(Console.ReadLine());


//this is the thing you want to do over and over as long as they want to keep going

            bool keepGoing = true;
    do 
    { 
        Console.Write("pls enter a number: ");
        string entry = Console.ReadLine();
        double num = double.Parse(entry);
        Console.WriteLine($"that number squared is: {num * num}");

//this is where we ask the user if they want to go again

            bool valid = false;

        do
        { 
            Console.Write("would you like to go again? (y/n):  ");
            entry = Console.ReadLine().ToLower();

            if (entry == "n" || entry == "no")
            {
                valid = true;
                keepGoing = false;
            }
            else if (entry == "y" || entry == "yes")
            {
                valid = true;
            }
        } 
        while (valid == false) ;
    } 
    while (keepGoing);