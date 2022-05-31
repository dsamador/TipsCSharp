
int x = 5;
int y = 3;

Console.WriteLine($"En main antes de invocar a = {x}, b = {y}");
intercambioCopia(x,y);
Console.WriteLine($"En main despues de invocar a = {x}, b = {y}");

Console.WriteLine("\r\n-----------\r\n");

Console.WriteLine($"En main antes de invocar a = {x}, b = {y}");
intercambioRef(ref x, ref y);
Console.WriteLine($"En main despues de invocar a = {x}, b = {y}");

static void intercambioCopia(int a, int b)
{
    Console.WriteLine($"En intCopia entra a = {a}, b = {b}");
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine($"En intCopia sale a = {a}, b = {b}");
}

static void intercambioRef(ref int a, ref int b)
{
    Console.WriteLine($"En intReferencia entra a = {a}, b = {b}");
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine($"En intReferencia sale a = {a}, b = {b}");
}