

int first = TimesTwo(5);
Console.WriteLine(first);

int second = SomeNumber();
Console.WriteLine(second);

double areaCir = CircleArea(3);
Console.WriteLine(areaCir);

double areaTrn = TriangleArea (3, 4);
Console.WriteLine(areaTrn);

//double areaPrn = PrintArea(5); //void oldugu icin return yok
//Console.WriteLine(areaPrn);

PrintArea(10);

static int TimesTwo(int num)
{
    //Console.WriteLine(first);// cannot do this because first is outside this funtions`s scope (disarda tanimlanan bir degisken de methodun icinde calismaz)
    //the variables num and result have a scope of this funtion only (bu methodun disinda calismiyorlar)

    int result = num * 2;
    return result;
}

static int SomeNumber()  //0 parametreli bir function- method
{
    return 20;
}

static double CircleArea(double radius)
{
    return Math.PI * radius * radius;
}

static double TriangleArea (int height, int width)
{
    return height * width / 2;  //add a .0 to the 2 (2=>2.0) to force the calculation to be double
}

static void PrintArea(double radius)
{
    double areaPrn = CircleArea(radius);
   // return 10; // void never work with return
}