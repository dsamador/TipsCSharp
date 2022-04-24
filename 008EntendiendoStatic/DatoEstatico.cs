namespace _008EntendiendoStatic
{
    public class DatoEstatico
    {
        private int _valor = 50;
        private static int _numero = 10;
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
