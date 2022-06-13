int n = 5;
string binario = "";

binario = Convert.ToString(n, 2).PadLeft(8,'0');
Console.WriteLine($"Bin:{binario}, Dec:{n}");

//Hacemos el shift a la izquierda por 1 bit
n = n << 1;
binario = Convert.ToString(n, 2).PadLeft(8, '0');
Console.WriteLine($"Bin:{binario}, Dec:{n}");

//Hacemos el shift a la izquierda por 3 bit
n = n << 3;
binario = Convert.ToString(n, 2).PadLeft(8, '0');
Console.WriteLine($"Bin:{binario}, Dec:{n}");

//Hacemos el shift a la derecha por 1 bit
n = n >> 3;
binario = Convert.ToString(n, 2).PadLeft(8, '0');
Console.WriteLine($"Bin:{binario}, Dec:{n}");