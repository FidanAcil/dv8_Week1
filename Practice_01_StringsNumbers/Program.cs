
//1=> Prompt the user to enter a string. After the user enters a string, output the same string back to the console.

Console.Write("Pls, enter a string:  ");
string entryStr = Console.ReadLine();
Console.WriteLine("the string is: {0}", entryStr);
Console.WriteLine("==============================================");

//===========================================================================================================================================

//2=> Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.

Console.Write("Pls, enter a number:  ");
//string entryNum = Console.ReadLine();
//int num1 = Convert.ToInt32(entryNum);

int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the new number is: {0}", num1+1);
Console.WriteLine("==============================================");

//===========================================================================================================================================

//3=> Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.

Console.Write("Pls, enter a number:  ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("the new number is: {0}", num2 + 0.5);
Console.WriteLine("==============================================");

//===========================================================================================================================================

//4=> Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.

Console.Write("Pls, enter the first number: ");
double numFirst = Convert.ToDouble(Console.ReadLine());

Console.Write("Pls, enter the second number: ");
double numSecond = Convert.ToDouble(Console.ReadLine());

double numSum = numFirst + numSecond;

Console.WriteLine("The sum of the numbers: {0} + {1} = {2}", numFirst, numSecond, numSum);

Console.WriteLine("==============================================");

//===========================================================================================================================================

//5=> Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.

Console.Write("Pls, enter the first number:  ");
double numFr = Convert.ToDouble(Console.ReadLine());

Console.Write("Pls, enter the second number:  ");
double numSc = Convert.ToDouble(Console.ReadLine());

double numMt = numFr * numSc;

Console.WriteLine("The multiply of the numbers: {0} * {1} = {2}", numFr, numSc, numMt);

Console.WriteLine("==============================================");

//===========================================================================================================================================