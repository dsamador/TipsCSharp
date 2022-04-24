namespace _008EntendiendoStatic
{
    public class MetodoEstatico
    {
        //private int valor = 50;           
        public void saluda()
        {
            Console.WriteLine("Solo saludo si hay " +
                "una instancia de clase");
        }
        public static void mensaje()
        {
            Console.WriteLine("Puedo dar el mensaje" +
                " si no hay una instancia de clase");
        }

        //public static void imprimeValor()
        //{
        //    Console.WriteLine($"El valor es {valor}");
        //}

        private static int numero = 10;
        public static void imprimeNumero()
        {
            Console.WriteLine($"El numero es {numero}");
        }
    }
}
