
namespace _032_Implementacion_virtual_de_interfaz
{
    //Esta clase no hace override a la implementacion de la interfaz
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
