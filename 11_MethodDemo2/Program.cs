
// 1=> Reference  => Pass by Reference

double first = 3.5;
double second = 4.5;
double area = RectangleArea(first, second);
Console.WriteLine($"Rectangle {first} by {second} has area {area}");

static double RectangleArea (double length, double width)
{
    double result = length * width;
    length = 100.0;  // burda bad data var : methodu calistirdi l:3.5 w:4.5 koydu
    width = 80.0;    // yeni degerlerini almadi - buna bak?
    return result;
}


// 2=> Out Parameter 

// double result = Divide (10.0, 0);
double result;
bool worked = Divide(10, 2, out result);
//Console.WriteLine(result);

if (worked)
{
    Console.WriteLine($"Great! The answer is {result}");
}
else
{
    Console.WriteLine("Sorry, you cannot divide by zero");
}


static bool Divide(double num1, double num2, out double result)
{
    if (num2 == 0)  // check if num 2 is zero, and if so, don`t do it
    {
        result = 0;
        return false;
    }
    else
    {
        result = num1 / num2;
        return true;
    }
}
