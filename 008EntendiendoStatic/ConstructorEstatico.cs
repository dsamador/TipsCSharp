namespace _008EntendiendoStatic
{
    public class ConstructorEstatico
    {
        private int _valor = 20;
        private static int _numero;
        static ConstructorEstatico()
        {            
            _numero = 33;
            Console.WriteLine("Saludos desde el constructor");
        }
        public void ponValor(int valor)
        {
            _valor = valor;
        }
        public void ponNumero(int numero)
        {
            _numero = numero;
        }
        public void muestraDatos()
        {
            Console.WriteLine($"Valor = {_valor}, numero = {_numero}");
        }
    }
}
