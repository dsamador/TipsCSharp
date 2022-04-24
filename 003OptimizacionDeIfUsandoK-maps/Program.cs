// Optimizando if con k-maps

//Programa que indica si una persona puede comprar un auto basado en las siguientes reglas.
//Es mayor de edad, tiene el dinero y tiene fiador
//No es mayor de edad, tiene el dinero y tiene fiador
//Es mayor de edad, no tiene el dinero y tiene fiador
//No es mayor de edad, tiene el dinero y no tinene fiador

int edad = 20;
int dinero = 50000;
bool fiador = false;

// if tradicional
Console.WriteLine("-----If tradicional-----");

//Este if tiene 23 evaluaciones
if ((edad >= 18 && dinero >= 35000 && fiador == true)||
    (edad < 18 && dinero >= 35000 && fiador == true)||
    (edad >= 18 && dinero < 35000 && fiador == true)||
    (edad < 18 && dinero >= 35000 && fiador == false))
    Console.WriteLine("Lo puede comprar");
else
    Console.WriteLine("No lo puede comprar");

Console.WriteLine("\n---- If optimizado----");

if ((edad < 18 && dinero >= 35000) || (edad >= 18 && fiador == true))
    Console.WriteLine("Lo puede comprar");
else
    Console.WriteLine("No lo puede comprar");




