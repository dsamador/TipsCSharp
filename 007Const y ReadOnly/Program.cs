const double iva = 0.16;
double valor = 5000.0;
double costoFinal = 0.0;

string dato = "";
double costoExtra = 0.0;

costoFinal = valor * iva;
Console.WriteLine($"El total es {costoFinal}");

//Usando ReadOnly
Console.WriteLine("Dame el valor del costo extra");
dato = Console.ReadLine();
costoExtra = Convert.ToDouble(dato);
Ejemplo objeto = new Ejemplo(costoExtra);
costoFinal += objeto.CostoExtra;

Console.WriteLine($"El gran total es {costoFinal}");

class Ejemplo
{
    private readonly double costoExtra;
    public Ejemplo(double costoExtra)
    {
        this.costoExtra = costoExtra;
    }
    public double CostoExtra
    {
        get { return costoExtra; }
    }
}