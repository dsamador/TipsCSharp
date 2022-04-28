﻿int a = 5;
int b = 8;
int r = 0;

int cantidad = 8;
int sumatoria = 0;
int factorial = 0;

double prom = 0.0;

//Invocamos el metodo normal.
r = SumaNormal(a, b);
Console.WriteLine($"El resultado es {0}");

//Intentamos intercambio por metodo normal
Console.WriteLine($"Antes del intercambio a = {a}, b = {b}");
IntercambioNormal(a, b);
Console.WriteLine($"Despues del intercambio a = {a}, b = {b}");
Console.WriteLine();

//Intentamos intercambio por referencia
Console.WriteLine($"Antes del intercambio por ref a = {a}, b = {b}");
IntercambioReferencia(ref a, ref b);
Console.WriteLine($"Despues del intercambio por ref a = {a}, b = {b}");
Console.WriteLine();


//metodo normal
static int SumaNormal(int x, int y)
{
    int z = 0;
    z = x + y;
    return z;
}

static void IntercambioNormal(int x, int y)
{
    int temp = 0;

    temp = x;
    x = y;
    y = temp;
}

static void IntercambioReferencia(ref int x, ref int y)
{
    int temp = 0;

    temp = x;
    x = y;
    y = temp;
}