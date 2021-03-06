int a = 5;
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

//Hacemos la invocacion para calcular sumatoria y factorial
Calculador(cantidad, out sumatoria, out factorial);
Console.WriteLine($"Sumatoria = {sumatoria}, factorial = {factorial}");
Console.WriteLine();

//Calcular varios promedios con un numero diferente de parametros
prom = Promedio(2.5, 6.7, 9.8);
Console.WriteLine($"El promedio es {prom}");
prom = Promedio(2.5, 6.7, 9.8, 7, 34, 2.3);
Console.WriteLine($"El promedio es {prom}");
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

static void Calculador(int n, out int s, out int f)
{
    s = 0;
    f = 1;
    int m = 0;

    for(m = 1; m <= n; m++)
    {
        s = s + m;
        f = f * m;
    }
}

static double Promedio(params double [] valores)
{
    double suma = 0.0;
    double prom = 0.0;
    int n = 0;
    for (n = 0; n < valores.Length; n++)
    {
        suma += valores[n];
    }
    prom = suma / valores.Length; 
    return prom;
}