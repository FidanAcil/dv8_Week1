

Random ran = new Random();

for (int i = 1; i <= 5; i++)  // 1 den 5 e kadar
{
    int num = ran.Next();  //gives us - the next random number - no up limit
    Console.WriteLine(num);

    int num1 = ran.Next(10); //gives us 5 numbers up to 10 
    Console.WriteLine(num1);

    int num2 = ran.Next(1, 7);
    Console.WriteLine(num2);
}