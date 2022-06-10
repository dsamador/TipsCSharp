
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
Condimentos condimentos = Condimentos.Queso;
DibujaHamburguesa(condimentos);

//Adicionamos otro condimento
condimentos = condimentos | Condimentos.Tomate;
DibujaHamburguesa(condimentos);

//Adicionamos otros condimentos
condimentos = condimentos | Condimentos.Lechuga | Condimentos.Cebolla;
DibujaHamburguesa(condimentos);

//Quitamos un condimento
condimentos -= Condimentos.Cebolla;
DibujaHamburguesa(condimentos);

//Limpiamos
condimentos = Condimentos.nada;
DibujaHamburguesa(condimentos);

[Flags]
enum Condimentos
{
    nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8
}
