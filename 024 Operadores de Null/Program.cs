string a = null;
string b = "hola";
string r;

r = a ?? "Fue un null";
Console.WriteLine(r);

r = b ?? "Fue un null";
Console.WriteLine(r);

Console.WriteLine("---------");

Console.WriteLine("Operador Null-Condicional o Elvis");
string rs = a.ToString();//null reference exception
string rs2 = a?.ToString();//No da error. Pero no pone nada
Console.WriteLine(rs2);

//Para que funcione, la expresion debe de aceptar un null

//int cantidad = a?.ToString().Length;
int? cantidad = a?.ToString().Length;