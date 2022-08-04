
//// Integers
//int x = 10;
//x = x * 2;
//x++;
//Console.WriteLine(x);  //21

//// Strings
//string product = "monitor";
//product = product.ToUpper();
//Console.WriteLine(product);   //MONITOR

//product = product.ToLower();
//Console.WriteLine(product);  //monitor

//// Double
//double first = 2.5;
//double pi = Math.PI;
//Console.WriteLine(first);  //2.5
//Console.WriteLine(pi);     //3.1415...

//double mult = first * pi;  
//Console.WriteLine(mult);   //7.85...
//double mult2 = first * Math.PI;
//Console.WriteLine(mult2);   //7.85..

//// Decimal (money)
//decimal charge = 10.25m;  //m for money
//Console.WriteLine(charge);
//decimal perc = charge / 3;
//Console.WriteLine(perc);  //

//// Boolean
//bool finished = false;
//Console.WriteLine(finished);  //false
//bool another = !finished;
//Console.WriteLine(another);   //true

//Console.WriteLine();

//int q = 20;
//bool test1 = (q > 10);  // not a question: is q greater than 10? instead a sentence: "q is greater than 10." is that true or false?
//Console.WriteLine(test1); // true

//// Let`s just print a couple our directly

//Console.WriteLine(q > 20);  //false statement: "q is greater than 20" expect to see: false
//Console.WriteLine(q == 20); //true  statement: "q is equal to 20" expect to see :true
//Console.WriteLine(q != 20); //false statement: "q is not equal to 20" expect to see :false 
//Console.WriteLine(  !(q != 20));  //true  statement: not 'q is not equal to 20" : true


// Let`s add in "and" => && "or" => ||

//&& : true-true
//|| : true - false

int j = 10;
int k = 11;

Console.WriteLine((j == 10) && (k == 11));  //true - true => true // statement is "j equals 10 AND k equals 11" expect to see true
Console.WriteLine((j == 10) && (k == 12));  //true - false => false // statement is "j equals 10 AND k equals 11" expect to see false


Console.WriteLine((j == 10) || (k == 12));  //true - false => true // statement is "j equals 10 OR k not equals 11" expect to see true
Console.WriteLine((j == 12) || (k == 12));  //false - false => false // statement is "j not equals 10 OR k not equals 11" expect to see false



