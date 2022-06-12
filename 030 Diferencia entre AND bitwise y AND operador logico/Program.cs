//Diferencia entre & y && 

using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();

int a = 0x08;
int b = 0x18;

// 00001000 - 8
// 00011000 - 24
// 00001000 - 8 

int r = a & b;
//Console.WriteLine($"0x{r:x}");

// Esto no se puede hacer, porque && es un operador logico
// r = a && b;

// & tambien trabaja con bool y lo toma como
// de dimension de 1 bit
bool x = true;
bool y = false;
bool z = x & y;
Console.WriteLine(z);

int m = 5;
int n = 3;

sw.Start();
for (int i = 0; i < 1000000; i++)
{
    if((m > 30) & (n < 10))
        Console.WriteLine(":)");
}
sw.Stop();
Console.WriteLine($"&: {sw.ElapsedTicks}");

sw.Reset();

sw.Start();
for (int i = 0; i < 1000000; i++)
{
    if ((m > 30) && (n < 10))
        Console.WriteLine(":)");
}
sw.Stop();
Console.WriteLine($"&&: {sw.ElapsedTicks}");
