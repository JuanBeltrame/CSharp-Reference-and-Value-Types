using System.Xml;

static void Swap(ref int x, ref int y)
{
    //Save the content (Copy) of x to temp
    int temp = x;
    //Now we can safely change the value of x since we have a copy of it in temp
    x = y;
    //Finally change y to be temp which is the orinigal value of x
    y = temp;
}
static void Swap2(int x, int y)
{
    //Save the content (Copy) of x to temp
    int temp = x;
    //Now we can safely change the value of x since we have a copy of it in temp
    x = y;
    //Finally change y to be temp which is the orinigal value of x
    y = temp;
}


//------Programa Principial------

// Define two numbers
int number01 = 5;
int number02 = 3;

int number03 = 6;
int number04 = 7;

int number05 = 8;
int number06 = 9;


//Print the values before swapping
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Values BEFORE swapping: {0} {1}", number01, number02);
// Save the content (copy) of number01 on temp
int temp = number01;
// now we can safely change the value of number01 since we have a copy of it in temp
number01 = number02;
// Finally change the number2 to be temp which is the original value of number1
number02 = temp;
// Print the values after swapping
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Values AFTER swapping: {0} {1}", number01, number02);
Console.WriteLine("-------------------------------------------------");


Console.WriteLine( );
Console.WriteLine( );
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Values BEFORE swapping: {0} {1}", number03, number04);
Swap(ref number03, ref number04);
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Values AFTER swapping: {0} {1}", number03, number04);
Console.WriteLine("-------------------------------------------------");


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Values BEFORE swapping: {0} {1}", number05, number06);
Swap2(number05,number06);
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Values AFTER swapping: {0} {1}", number05, number06);
Console.WriteLine("-------------------------------------------------");
Console.ReadKey();



