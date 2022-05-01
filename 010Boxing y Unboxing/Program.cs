using System.Collections;


//Boxing que ocurre en las colecciones
ArrayList arrayList = new ArrayList();

arrayList.Add(5);
arrayList.Add(9);

//Esta linea marca error
//int resultado = arrayList[0] + arrayList[1];

int resultado = (int)arrayList[0] + (int)arrayList[1];
Console.WriteLine($"El resultado es {resultado}");


// Variable normal
int valor = 5;

// Hacemos el boxing creando una referencia
object boxDato = 7;

// Esta linea marca error
// valor = valor + boxDato

// Hacemos el unboxing
int unboxDato = (int)boxDato;
valor = valor + unboxDato;

Console.WriteLine(valor);

 
//Metodo que fuerza al boxing
static void Muestra(object o)
    => Console.WriteLine($"Lo que recib[i es {o}");


//Metodo que fuerza al boxing
static void Multiplica (object o)
{
    //Para hacer la operacion debemos llevar a cabo unboxing
    // Esto causa error
    //Console.WriteLine($"Lo que recibi es {o * 2}");

    int temp = (int)o;
    Console.WriteLine($"Lo que calcule es {temp * 2}");
}

