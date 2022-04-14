bool booleana = true;
char caracter = 'a';
string cadena = "Hola";

//con bool
switch (booleana)
{
    case true:
        Console.WriteLine("Es true");
        break;
    case false:
        Console.WriteLine("Es false");
        break;
}

//con caracter
switch (caracter)
{
    case 'a':
    case 'e':        
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Es vocal");
        break;
    default:
        Console.WriteLine("Es consonante");
        break;
}

switch (cadena)
{
    case "Hola":
        Console.WriteLine("Espagnol");
        break ;
    case "Hello":
        Console.WriteLine("English");
        break;
    case "Priviet":
        Console.WriteLine("Russian");
        break;
}