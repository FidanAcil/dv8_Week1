
int first = 20;
int second = 30;

Console.WriteLine("==========================================");
Console.WriteLine("function starts to working for product-0");
int product0 = Multiply(first, second);
Console.WriteLine("product-0 is: {0}", product0);

Console.WriteLine("==========================================");
Console.WriteLine("function starts to working for product-1");
int product1 = Multiply(5, 10);
Console.WriteLine("product-1 is: {0}", product1);

Console.WriteLine("==========================================");
Console.WriteLine("function starts to working for product-2");
Console.WriteLine("Getting Started!");
int product2 = Multiply(5, 10);
Console.WriteLine("product-2 is: {0}", product2);
Console.WriteLine("All done!");

Console.WriteLine("==========================================");
Console.WriteLine("function starts to working for product-3");
Console.WriteLine("Getting Started!");
int product3 = Multiply(first, second);
Console.WriteLine("product-3 is: {0}", product3);
Console.WriteLine("All done!");

Console.WriteLine("==========================================");
Console.WriteLine("function starts to working for product-4");
int product4 = Multiply(first, 50);
Console.WriteLine("product-4 is: {0}", product4);

Console.WriteLine("==========================================");
Console.WriteLine("function starts to working for product-5");
int product5 = Multiply(second, 2);
Console.WriteLine("product-5 is: {0}", product5);

Console.WriteLine("==========================================");
Console.WriteLine("function starts to working for product-6");
int product6 = Multiply(product4, product5);
Console.WriteLine("product-6 is: {0}", product6);

static int Multiply (int x, int y)    //functions-methods: 2 parameter, return: multiply
{
    Console.WriteLine("we are inside the function!");
    Console.WriteLine($"The value of x is {x}");
    Console.WriteLine($"The value of x is {y}");
    return x * y;
}