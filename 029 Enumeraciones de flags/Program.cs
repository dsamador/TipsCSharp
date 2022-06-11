
static void DibujaHamburguesa(Condimentos condimento)
{
    //Dibujamos tapa
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("(====)");

    //Verificamos si tiene tomate
    if((condimento & Condimentos.Tomate) != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" ==== ");
    }

    //verificamos si tiene lechuga
    if((condimento & Condimentos.Lechuga) != 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" ^^^^ ");
    }

    //verificamos si tiene cebolla
    if((condimento & Condimentos.Cebolla) != 0)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" #### ");
    }

    //verificamos si tiene queso
    if((condimento & Condimentos.Queso) != 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" ---- ");
    }

    //La carne
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(" ==== ");
    
    //La base
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("(====)");

    Console.WriteLine("\r\n -------------- \r\n");
}


//Colocamos un condimento
Condimentos ingredientes = Condimentos.Queso;
DibujaHamburguesa(ingredientes);

//Adicionamos otro condimento
ingredientes = ingredientes | Condimentos.Tomate;
DibujaHamburguesa(ingredientes);

//Adicionamos otros condimentos
ingredientes = ingredientes | Condimentos.Lechuga | Condimentos.Cebolla;
DibujaHamburguesa(ingredientes);

//Quitamos un condimento
ingredientes -= Condimentos.Cebolla;
DibujaHamburguesa(ingredientes);

//Limpiamos
ingredientes = Condimentos.nada;
DibujaHamburguesa(ingredientes);

Console.WriteLine(
           "\nAll possible combinations of values with FlagsAttribute:");
for (int val = 0; val <= 16; val++)
    Console.WriteLine("{0,3} - {1:G}", val, (Condimentos)val);

[Flags]
enum Condimentos
{
    nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8
}
