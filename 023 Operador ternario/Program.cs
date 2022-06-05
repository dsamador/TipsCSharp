
//Operador ternario
// condicion ? V : F

int a = 15;
int b = 3;
int r = 0;

//selecciona el mayor
r = (a > b) ? a : b;
Console.WriteLine($"El mayor es {r}");

//Llevamos a cabo una asignacion
r = (a < 6) ? a = 10 : a = -10;
Console.WriteLine($"a = {a}, r = {r}");

//Hacemos incremento
r = (a > 5) ? a++ : b++;
Console.WriteLine($"a = {a}, b = {b}, r = {r}");

//Hacemos invocacion a un metodo
static int mensaje()
{
    Console.WriteLine("Hola");
    return 50;
}
r = (a < 0) ? mensaje() : 0;
Console.WriteLine($"r = {r}");