string name = "Fred";
Console.WriteLine(name);
string upperName = name.ToUpper();  //Strings are immutable (unchangeable)
Console.WriteLine(upperName);       //FRED
Console.WriteLine(name);

Console.WriteLine(name[0]);  //index 0 element
Console.WriteLine(name[1]);
Console.WriteLine(name[2]);
Console.WriteLine(name[3]);

Console.WriteLine(name.ToLower());  //fred



// Floating Point Types

//double

double pi = 3.1415926;
Console.WriteLine(pi);     //3.1415926

double pi2 = pi * 2;
Console.WriteLine(pi2);     //6.2831..

Console.WriteLine(Math.Sqrt(pi));   //1.77.. Square root - karakok

double q = Math.Sqrt(25);
Console.WriteLine(q);


//float
float n = 3.1415f; //we rarely use float these days. put an F or f after it to initialize it

float k = 10;
k = k / 3;
Console.WriteLine(k);      //3.33333
Console.WriteLine(k+k+k);  //10

//decimal: when we working with money, we don`t use float or double. - use decimal

decimal amount = 99.95m;
Console.WriteLine(amount);  //99.95
amount = amount * 2;
Console.WriteLine(amount);  //199.90

//boolean: logic statements

bool passed = true;
Console.WriteLine(passed);
passed = false;
Console.WriteLine(passed);

passed = !passed;  //passed was false; the "not" operator flips it to true
Console.WriteLine(passed);

