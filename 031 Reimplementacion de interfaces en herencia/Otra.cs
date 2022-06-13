namespace _031_Reimplementacion_de_interfaces_en_herencia
{
    public class Otra : Prueba
    {
        public Otra(double valor) : base(valor)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("En el constructor de Otra");
            calcular(valor);
            Console.WriteLine("Saliendo del constructor de Otra");
        }
    }
}
