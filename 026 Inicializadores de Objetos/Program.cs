using _026_Inicializadores_de_Objetos;

Prueba p = new Prueba { a = 1, b = 2, c = "Saludos"};
Console.WriteLine(p);

Prueba p1 = new Prueba("Saludo 2") { a = 1, b = 2 };
Console.WriteLine(p1);