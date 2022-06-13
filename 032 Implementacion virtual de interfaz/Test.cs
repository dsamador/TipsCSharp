namespace _032_Implementacion_virtual_de_interfaz
{
    public class Test : Prueba
    {
        double numero;
        public Test(double valor) : base(valor)
        {
            numero = valor;
        }
        //Override a implementacion
        public override void calcular(double valor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Version de Test {numero + valor}");
        }
    }
}
