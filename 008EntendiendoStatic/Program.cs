using _008EntendiendoStatic;

//MetodoEstatico.saluda();

//MetodoEstatico obj = new MetodoEstatico();
//obj.saluda();

//MetodoEstatico.mensaje();

//MetodoEstatico.imprimeNumero();


//Creamos tres instancias
//DatoEstatico obj1 = new DatoEstatico();
//DatoEstatico obj2 = new DatoEstatico();
//DatoEstatico obj3 = new DatoEstatico();

//Console.WriteLine("Imprimimos antes de cambios");
//obj1.muestraDatos();
//obj2.muestraDatos();
//obj3.muestraDatos();

////Cambiamos datos e imprimimos
//obj1.ponValor(3);
//obj2.ponValor(57);
//obj3.ponValor(140);
//Console.WriteLine("Imprimimos con cambios a valor");
//obj1.muestraDatos();
//obj2.muestraDatos();
//obj3.muestraDatos();

////Cambiamos el numero solo en un objeto
//obj2.ponNumero(300);
//Console.WriteLine("Imprimimos con cambio a numero");
//obj1.muestraDatos();
//obj2.muestraDatos();
//obj3.muestraDatos();

//Creamos dos objetos

ConstructorEstatico obj1 
    = new ConstructorEstatico();
ConstructorEstatico obj2 
    = new ConstructorEstatico();

Console.WriteLine("Sin cambio");
obj1.muestraDatos();
obj2.muestraDatos();
//cambiamos
obj1.ponValor(400);
obj1.ponNumero(555);
Console.WriteLine("Con cambios");
obj1.muestraDatos();
obj2.muestraDatos();
//creamos otra instancia
ConstructorEstatico obj3
    = new ConstructorEstatico();
Console.WriteLine("Despues de la instancia");
obj1.muestraDatos();
obj2.muestraDatos();
obj3.muestraDatos();






















