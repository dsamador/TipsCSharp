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

//Encontramos el lugar donde aparece una cadena
indice = mensaje.IndexOf("Tiene");
Console.WriteLine($"La palabra aparece en el indice {indice}");
Console.WriteLine("-------------------");

//Encontramos el lugar donde aparece un valor por ultima vez
indice = mensaje.LastIndexOf('a');
Console.WriteLine($"Aparace por ultimo en el indice {indice}");
Console.WriteLine("-------------------");

//Indicamos la longitud y se llena con espacios
//Programando tiene 11 caracteres, con el 15 sumamos 4
//espacios a la izquierda.
string mensaje3 = "Programando";
string pad = mensaje3.PadLeft(5);
Console.WriteLine(pad);
Console.WriteLine("-------------------");

//Removemos caracteres desde la posicion indicada
string remover = mensaje.Remove(7);
Console.WriteLine(remover);
Console.WriteLine("-------------------");

//Reemplazamos caracteres o subcadenas
string reemplazo = mensaje.Replace('a', 'i');
Console.WriteLine(reemplazo);
reemplazo = mensaje.Replace("saludos", "regalos");
Console.WriteLine(reemplazo);
Console.WriteLine("-------------------");

//Separar palabras teniendo en cuenta el espacio en blanco
//y el punto como separadores
string[] palabras = mensaje.Split(new char[] { ' ', '.' });
foreach(string palabra in palabras)
    Console.WriteLine(palabra);
Console.WriteLine("-------------------");

//Retorna bool si la cadena empieza por hola.
bool empieza = mensaje.StartsWith("hola");
Console.WriteLine(empieza);
Console.WriteLine("-------------------");

//Obtenemos una subcadena desde un indice hasta otro
string subcadena = mensaje.Substring(7, 12);
Console.WriteLine(subcadena);
Console.WriteLine("-------------------");

//Mandamos a minusculas
string mensaje4 = "ESTE mensaje tiene Mayusculas";
string minusculas = mensaje4.ToLower();
string mayusculas = mensaje4.ToUpper();
Console.WriteLine(minusculas);
Console.WriteLine(mayusculas);
Console.WriteLine("-------------------");

//Eliminamos el exceso de caracteres TrimEnd/Start
string limpio = mensaje.Trim(new char[] {'!'});
Console.WriteLine(limpio);
Console.WriteLine("-------------------");