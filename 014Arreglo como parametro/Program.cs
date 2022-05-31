using System;

namespace _014Arreglo_como_parametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mando = { 4, 5, 1, 6, 8, 7, 3 };
            int[] recibo;
            int n = 0;

            //mandamos el arreglo
            imprime(mando);

            //solicitamos el arreglo
            recibo = crea();
            for (n = 0; n < recibo.Length; n++)
                Console.Write($"{recibo[n]},");
            Console.WriteLine();
        }
        public static void imprime(int[] arreglo)
        {
            int n = 0;
            for (n = 0; n < arreglo.Length; n++)
                Console.Write($"{arreglo[n]},");
            Console.WriteLine();
        }
        public static int[] crea()
        {
            int[] temp = new int[4];
            int n = 0;
            Random rand = new Random();
            for (n = 0; n < 4; n++)
                temp[n] = rand.Next(10);
            return temp;
        }
    }
}
