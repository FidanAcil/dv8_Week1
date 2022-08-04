
/* 1 => * piramit ex
*
**
***
****
*****
*/

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine("=============================================");

/* 2 => ters piramit ex
 *****
 ****
 ***
 **
 */

for (int i = 10; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}