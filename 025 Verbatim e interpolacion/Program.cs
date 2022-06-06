
string a = "Hola a \todos";
Console.WriteLine(a);

string b = @"Hola a \todos";
Console.WriteLine(b);

string c = @"Permite usar 
            multiples lineas
a la vez";

Console.WriteLine(c);

int n = 5;
int m = 6;

string d = "Sin interpolacion {n + m}";
string e = $"Con interpolacion {n + m}";
Console.WriteLine(d);
Console.WriteLine(e);

static int DaValor() => 15;
string f = $"El valor es: {DaValor()}";

string g = @$"Mezcla de \todos tanto $ como @ 
{DaValor()} 
multiples lineas";
Console.WriteLine(g);