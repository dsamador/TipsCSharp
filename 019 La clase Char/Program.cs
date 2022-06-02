
Console.WriteLine("----- IsDigit");
Console.WriteLine(char.IsDigit('a'));//False
Console.WriteLine(char.IsDigit('9'));//True
Console.WriteLine(char.IsDigit('.'));//False
Console.WriteLine(char.IsDigit("costo 5", 6));//True

Console.WriteLine("----- IsLetter");
Console.WriteLine(char.IsLetter('F'));//True
Console.WriteLine(char.IsLetter('>'));//False
Console.WriteLine(char.IsLetter('9'));//False
Console.WriteLine(char.IsLetter("Hola 5", 3));//True

Console.WriteLine("----- IsWhiteSpace");
Console.WriteLine(char.IsWhiteSpace("Hola Juan", 3));//False
Console.WriteLine(char.IsWhiteSpace("Hola Juan", 4));//True

Console.WriteLine("----- IsLetterOrDigit");
Console.WriteLine(char.IsLetterOrDigit('d'));//True
Console.WriteLine(char.IsLetterOrDigit('5'));//True
Console.WriteLine(char.IsLetterOrDigit("Hola.5", 4));//False

Console.WriteLine("----- IsPunctuation");
Console.WriteLine(char.IsPunctuation('.'));//True
Console.WriteLine(char.IsPunctuation('D'));//False

Console.WriteLine("----- IsSymbol");
Console.WriteLine(char.IsSymbol('F'));//False
Console.WriteLine(char.IsSymbol('>'));//True

Console.WriteLine("----- ToLower");
Console.WriteLine(char.ToLower('F'));//f
Console.WriteLine(char.ToLower('.'));//.
Console.WriteLine(char.ToLower('s'));//s

Console.WriteLine("----- ToUpper");
Console.WriteLine(char.ToUpper('F'));//F
Console.WriteLine(char.ToUpper('.'));//.
Console.WriteLine(char.ToUpper('s'));//S