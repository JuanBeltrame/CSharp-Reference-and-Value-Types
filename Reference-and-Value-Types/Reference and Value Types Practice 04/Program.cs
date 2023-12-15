//--------Example Using OUT--------
static bool TryDivide(int x, int y, out int result)
{
    if (y != 0)
    {
        result = x / y;
        return true;
    }
    else
    {
        result = default;
        return false;
    }
}


//-----------Programa Principal-----------
// Primer Ejemplo
int num;
string numToParse = "8";

if (int.TryParse(numToParse, out num))
{
    Console.WriteLine("The number was parsed value: " + num);
}
else
{
    Console.WriteLine("Could not parsethe number value: " + num);
}


// Segundo Ejemplo
int firstNumber = 4;
int secondNumber = 0;

if (TryDivide(firstNumber,secondNumber, out int result))
{
    Console.WriteLine("{0}/{1}={2}", firstNumber, secondNumber, result);
}
else
{
    Console.WriteLine("Can't divide by zero");
}