namespace _008EntendiendoStatic
{
    static class ClaseEstatica
    {
        private static int _valor = 20;
        private static int _numero;
        static ClaseEstatica()
        {
            _numero = 33;
            Console.WriteLine("Saludos desde el constructor");
        }
        public static void ponValor(int valor)
        {
            _valor = valor;
        }
        public static void ponNumero(int numero)
        {
            _numero = numero;
        }
        public static void muestraDatos()
        {
            Console.WriteLine($"Valor = " +
                $"{_valor}, numero = {_numero}");
        }
    }
}
