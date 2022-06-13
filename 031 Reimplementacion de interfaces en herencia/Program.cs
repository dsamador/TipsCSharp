using _031_Reimplementacion_de_interfaces_en_herencia;

//Reimplementacion de interfaces en herencia
Prueba o1 = new Prueba(45);
o1.calcular(12.5);
Console.WriteLine("-------");

Otra o2 = new Otra(10);
Console.WriteLine("-------");

Test o3 = new Test(45);
o3.calcular(12.5);
Console.WriteLine("-------");

//Gracias al polimorfismo
//podemos usar la version original
((Prueba)o3).calcular(12.5);
