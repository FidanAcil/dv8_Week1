//01_Week_04_Lab : Dice Roller

Console.WriteLine("Welcome to Grand Circus Casino!");
Console.WriteLine("***********************************************");
Console.WriteLine();

Console.Write("How many sides should each dice have? Please, enter the number:  ");
int numDice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (true)
{

}



static int numRandom (int x, int y)
{
    Random ran = new Random();

    for (int i = 0; i <= x; i++)
    {
        for (int j = 0; j <= y; j++)
        {
            int num = ran.Next(i, j);
            return num;
        }
    }
}