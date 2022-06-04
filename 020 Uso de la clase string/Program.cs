string mensaje = "Hola, saludos a todos!!!!!!!!!!!!!!!!";

//verificamos si hay una subcadena
bool tiene = mensaje.Contains("saludos");
Console.WriteLine(tiene);
Console.WriteLine("-------------------");

//Verificamos si termina en una subcadena en particular.
bool termina = mensaje.EndsWith(".");
Console.WriteLine(termina);
Console.WriteLine("-------------------");

//Creamos una cadena por medio de formato
int edad = 20;
string mensaje2 = String.Format("La persona tiene {0} years de edad", edad);
Console.WriteLine(mensaje2);
Console.WriteLine("-------------------");

//Encontramos el lugar donde aparece determinado caracter por primera vez
int indice = 0;
indice = mensaje.IndexOf('s');
Console.WriteLine($"La s aparece en el indice {indice}");
Console.WriteLine("-------------------");

