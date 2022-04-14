string nombre = "";
int repeticiones = 0;
int n = 0;

//verificar que se tenga la cantidad de argumentos
if (args.Length != 2)
{
    Console.WriteLine("Debe poner el nombre y las repeticiones");
}
else
{
    //obtener los argumentos
    nombre = args[0];
    repeticiones = Convert.ToInt32(args[1]);

    //hacemos el saludo
    for (int i = 0; i < repeticiones; i++)    
        Console.WriteLine($"Hola {nombre}");
}