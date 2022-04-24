double miDoble = 123456.7890123;
int miInt = 637;

Console.WriteLine("Impresiones normales");
Console.WriteLine($"El entero {miInt}");
Console.WriteLine($"El doble {miDoble}");
Console.WriteLine("-----------------");
Console.WriteLine("Impresiones con formato");
Console.WriteLine($"Moneda {miDoble:C}");
Console.WriteLine($"Rellena lugares {miInt:D5}");
Console.WriteLine($"Exponente {miDoble:E}");
Console.WriteLine($"Lugares decimales {miDoble:F3}");
Console.WriteLine($"Exponente con lugares {miDoble:G3}");
Console.WriteLine($"Exponente con lugares {miDoble:G5}");
Console.WriteLine($"Formato numerico {miDoble:N}");
Console.WriteLine($"En Hexadecimal {miInt:X4}");

