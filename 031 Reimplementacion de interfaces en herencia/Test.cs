namespace _031_Reimplementacion_de_interfaces_en_herencia
{
    public class Test : Prueba
    {
        double numero;
        public Test(double valor) : base(valor)
        {
            numero = valor;
        }
        //Reimplementacion de calcular
        public new void calcular(double valor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Version de Test {numero + valor}");
        }
    }
}
