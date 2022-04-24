namespace _008EntendiendoStatic
{
    public class EstaticoEnConstructor
    {
        private int _valor;
        private static int _numero;

        public EstaticoEnConstructor()
        {
            _valor = 20;
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
