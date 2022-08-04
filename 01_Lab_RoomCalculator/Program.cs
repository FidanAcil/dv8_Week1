// 01_Week : 01_Lab : Room Calculator

Console.WriteLine("Welcome to Grand Circus` Room Detail Generator!");
Console.WriteLine("***********************************************");
Console.WriteLine();

double valLength;
double valWidth;
double valHeight;

Console.Write("Enter the values of Length of the classroom: ");
valLength = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the values of Width of the classroom: ");
valWidth = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the values of Height of the classroom: ");
valHeight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double rectPerimeter = 2 * (valWidth + valLength);
Console.WriteLine("The classroom Perimeter is: {0}", rectPerimeter);
Console.WriteLine();

double rectArea  = valWidth * valLength;
Console.WriteLine("The classroom Area is: {0}",rectArea);
Console.WriteLine();

if (rectArea <= 250)
{
    Console.WriteLine("The classroom is Small");
}
else if (rectArea > 250 && rectArea < 650)
{
    Console.WriteLine("The classroom is Medium");
}
else
{
    Console.WriteLine("The classroom is Large");
}
Console.WriteLine();

double rectVolume = valLength * valWidth * valHeight;
Console.WriteLine("The classroom Volume is: {0}", rectVolume);
Console.WriteLine();

double rectSurfaceArea = 2 * ( (valLength * valWidth) + (valLength * valHeight) + (valWidth * valHeight));
Console.WriteLine("The classroom Surface Area is: {0}", rectSurfaceArea);