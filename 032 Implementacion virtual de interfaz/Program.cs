using _032_Implementacion_virtual_de_interfaz;

//Implementacion virtual de interfaces
Prueba o1 = new Prueba(45);
o1.calcular(12.5);
Console.WriteLine("-------");

Otra o2 = new Otra(10);
Console.WriteLine("-------");

Test o3 = new Test(45);
o3.calcular(12.5);
Console.WriteLine("-------");

//En este punto el polimorfismo no funciona.
((Prueba)o3).calcular(12.5);


