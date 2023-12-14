using Reference_and_Value_Types_Practice_02;

static void CambiarValor01(int numero)
{
    numero = 90;
}

static void CambiaValorusanadoRef(ref int numero)
{
    numero = numero * 2;
}

static void CambiarValor02(Persona persona)
{
    persona.Nombre = "Mauricio Verona";
}

//------------Programa Principal-------------

// Tipo de valor, por que es una (estructura)
int numero = 12;
CambiarValor01(numero);
Console.WriteLine(numero);

// Ejemplo usando ref
int otroNumero = 12;
CambiaValorusanadoRef(ref otroNumero);
Console.WriteLine(otroNumero);


// Tipo de Referencia, porque es una(clase)
Persona persona = new Persona()
{
    Nombre = "Juan Beltrame"
};
CambiarValor02(persona);
Console.WriteLine(persona.Nombre);
Console.ReadKey();