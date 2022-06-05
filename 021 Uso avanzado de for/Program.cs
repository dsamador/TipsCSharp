int n = 0;
for (n = 0; n < 5; n++)
    Console.WriteLine(n);

Console.WriteLine($"El valor final es {n}");

for (; n < 10; n++)
    Console.WriteLine($"->{n}");

int m = 0;
for(n = 0, m = 5; n < 5; n++, m--)
    Console.WriteLine($"n={n}, m={m}");

for (n = 0; n < 5;)
{
    Console.WriteLine("Infinito");
    n++;
}

for (n= 1, m= 1; n % 12 != 0 && m % 12 != 0; n++, m = m + 3)
    Console.WriteLine($"n={n}, m={m}");


static bool comparacion(int a, int b)
{
    bool resultado = false;
    if (a % 12 != 0 && b % 12 != 0)
        resultado = true;
    else
        resultado = false;
    return resultado;
}

for (n= 1, m= 1; comparacion(n,m); n++, m = m + 3)
    Console.WriteLine($"n={n}, m={m}");


