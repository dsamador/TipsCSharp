
using _027_Mas_sobre_propiedades;

Prueba obj = new Prueba(50);

double pv = obj.PrecioVenta;
Console.WriteLine($"Precio venta: {pv}");

double imp = obj.Impuesto;
Console.WriteLine($"Impuesto: {imp}");

obj.Descuento = 15;
double precioDescuento = obj.Descuento;
Console.WriteLine($"El precio con descuento: {precioDescuento}");

Console.WriteLine($"Objetos en existencia {obj.Inventario}");

//No es permitido porque el set es privado
//obj.Garantia = 3;

Console.WriteLine($"La garantia es por {obj.Garantia} years");

obj.ponerGarantia(12345, 3);
Console.WriteLine($"La garantia es por {obj.Garantia} years");