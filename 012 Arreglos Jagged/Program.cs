

int[][] numeros = new int[4][];//Cuatro renglones

//Instanciar cada renglon
numeros[0] = new int[3];
numeros[1] = new int[4];
numeros[2] = new int[2];
numeros[3] = new int[3];

int n = 0;
int m = 0;
string dato = "";

// Recorremos el arreglo pidiendo informacion
for (n = 0; n < 4; n++)
{
    for (m = 0; m < numeros[n].GetLength(0); m++)
    {
        Console.WriteLine($"Dame el numero {m} del renglon {n}");
        dato = Console.ReadLine();
        numeros[n][m] = Convert.ToInt32(dato);
    }
    Console.WriteLine();
}
for (n = 0; n < 4; n++)//Imprimir datos
{
    for (m = 0; m < numeros[n].GetLength(0); m++)    
        Console.Write($"{numeros[n][m]},");        
    Console.WriteLine();
}

