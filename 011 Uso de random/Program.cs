/*Instanciar la clase
 Obtener de diferentes formas numeros aleatorios
 Usar tecnicas de depuracion cuando usemos random*/

/*Los numeros random son numeros que se escogen
al azar. Realmente no son tan aleatorios ya que se
seleccionan de una tabla muy grande de numeros y 
nos son dados como si fueran aleatorios*/

/*En C# los numeros random se sacan de una clase
llamada Random*/

//variables
Random random = new Random();

int n = 0;
int numero = 0;
double valor = 0.0;
byte[] bytes = new byte[3];

//Numero entre cero y 2,147,483,647
numero = random.Next();
Console.WriteLine(numero);

//Numero entre cero y menor al que coloque. El 
//colocado debe ser > 0 y menor a 19
numero = random.Next(20);
Console.WriteLine(numero);

//Numero entre el menor y menor al que sea mayor
numero = random.Next(-15, 10);//-11, 0, 9
Console.WriteLine(numero);

//Numero entre 0 y 1
valor = random.NextDouble();
Console.WriteLine(valor);

//Llena el arreglo con valores entre 0 y 255
random.NextBytes(bytes);
for (n = 0; n < 3; n++)
    Console.WriteLine(bytes[n]);


Random random2 = new Random((int)DateTime.Now.Ticks
    & 0x0000FFFF);

/*Si colocamos un valor fijo vamos a tener los 
mismos numeros aleatorios, es decir ya no seran
aleatorios.*/
Random random3 = new Random(50);