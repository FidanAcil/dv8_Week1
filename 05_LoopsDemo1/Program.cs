// 1 => FOR LOOP

for (int index = 0; index < 10; index = index + 1)  //index 0 esit, 10 dan kucuk olana kadar, 1 arttiracak
{
    Console.WriteLine("we are inside the loop");
    Console.WriteLine(index);
    Console.WriteLine("now the inside code is done");
    Console.WriteLine();
    //index = index + 1; => no need 

}
Console.WriteLine("All done");

// Note: The index variable lives only during the loop and is then forgotten

//int i = 5; //decleare a variable
//for (int i = 0; i < length; i++)   // sadece i yi burda kullaniyoruz, bi tane variable tanimli degil
//{

//}
// Console.WriteLine(i);

for (int i = 3; i < 0; i++)   //false i cunku 3, 0 dan kucuk olamaz
{

}

for (int j = 0; j < 10; j += 2)  // j = j+2
{

}

for (int k = 10; k >= 0; k -= 3)    // k = k -3
{

}

// 2 => WHILE LOOP

int w = 1;      //w 1 den baslar 5 den kucuk oldugu surece while loop calisir, w++ koymazsak hep 1 icin calisir - infinite loop olur

while (w < 5)
{
    Console.WriteLine("inside while loop");
    Console.WriteLine(w);
    w++;
}

// Example of a break statement inside a while (true)

Console.WriteLine();

int w2 = 10;

while(w2 >= 0)
{
    Console.WriteLine(w2);
    w2--;
}


int w3 = 10;
while (w3 >= 0)
{
    if (w3 == 4)
    {
        Console.WriteLine("oops, found corrupted data");
        break;  // this exits the loop immediately (break does not exit of if statements)
    }
    Console.WriteLine(w3);
    w3--;
}
Console.WriteLine("finished with while loops, on to do ");


int w4 = 20;   //never bu loopa girmez w4 20 cunku - condition 10 dan kucuk olmali
while (w4 < 10)
{

}

// with while loops, the condition is tested before each iteration
// with do/while loops, the condition is tested after each iteration


// 3 => DO_WHILE LOOP

int z = 0;

do
{
    Console.WriteLine(z);
    z++;
}
while (z < 10);

// at least one time loop works z1 = 0, while -2 den kucuk degil, ama bir kez 0 icin calisti

int z1 = 0;
do
{
    Console.WriteLine(z1);
    z++;
}
while (z1 < -2);


Console.WriteLine("All done with while loops! now a nested for loop");

// 4 => NESTED FOR LOOP

for (int x = 1; x <= 5; x++)
{
    Console.WriteLine($"starting outer loop x is {x}");

    for (int y = 1; y <= 3; y++)
    {
        Console.WriteLine($"x:{x}  y:{y}");
    }
    Console.WriteLine();
}

//Ex; Clock

Console.WriteLine("How about a clock!");

for (int hour = 0; hour < 24; hour++)
{
    Console.WriteLine($"The hour is: {hour}");

    for (int minute = 0; minute < 60; minute++)
    {
        Console.WriteLine($"  {hour} : {minute}");
        Console.WriteLine("{0} : {1}", hour, minute);
    }
}
