using _018_Override_a_Object;

Persona persona = new Persona("J", 3);

Console.WriteLine("------ToString------");
Console.WriteLine(persona.ToString());

Console.WriteLine("------GetType------");
Console.WriteLine(persona.GetType());
Console.WriteLine(persona.GetType().BaseType);

Persona persona2 = new Persona("J", 3);

Console.WriteLine("------Equals------");
if (persona.Equals(persona2))
    Console.WriteLine("Son iguales");
else
    Console.WriteLine("No son iguales");

Object persona3 = persona;
if (persona3.Equals(persona))
    Console.WriteLine("Son iguales");
else
    Console.WriteLine("No son iguales");

Console.WriteLine(persona.GetHashCode());