namespace _032_Implementacion_virtual_de_interfaz
{
    public class Prueba : Icalculable
    {
        private double n;

        public Prueba(double valor)
        {
            n = valor;
        }
        //Implementacion de la interface
        // Hay que notar que la estamos marcando como virtual
        // por default las implementaciones son sealed
        public virtual void calcular(double numero)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Estoy en prueba {n * numero}");
        }
    }
}
