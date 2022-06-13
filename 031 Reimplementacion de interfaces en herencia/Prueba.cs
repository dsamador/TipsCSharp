
namespace _031_Reimplementacion_de_interfaces_en_herencia
{
    public class Prueba : ICalculable
    {
        private double n;

        public Prueba(double valor)
        {
            n = valor;
        }
        //Implementacion de la interface
        public void calcular(double numero)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Estoy en prueba {n * numero}");
        }
    }
}
