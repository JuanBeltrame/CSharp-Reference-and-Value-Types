static void CambiarValor01(ref int number)
{
    number = number * 2;
}

static void CambiarValor02(out int number)
{
    number = 12;
    number = number * 2;
}


//----------Programa Principal-------------
// Usando ref
int numero01 = 12;
CambiarValor01(ref numero01);
Console.WriteLine(numero01);

// Usando out
int numero02;
CambiarValor02(out numero02);
Console.WriteLine(numero02);
Console.ReadKey();
