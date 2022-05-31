using System.Collections;

ArrayList ciudades = new ArrayList();
int[] valores = new int[4];

ciudades.Add("Santa Marta");
ciudades.Add("Guachaca");
ciudades.Add("Cienaga");
ciudades.Add("Utica");
ciudades.Add("Barranquilla");

valores[0] = 5;
valores[1] = 9;
valores[2] = 7;
valores[3] = 10;

foreach (var item in ciudades)
    Console.WriteLine($"La ciudad es {item}");

foreach (var item in valores)
    Console.WriteLine($"El numero es {item}");

for (int i = 0; i < ciudades.Count; i++)
{
    Console.WriteLine($"La ciudad es {ciudades[i]}");
}

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"El numero es {valores[i]}");
}
