namespace _026_Inicializadores_de_Objetos
{
    public class Prueba
    {

        public int a;
        public int b;
        public string c;

        public Prueba()
        {                      
        }
        public Prueba(string c)
        {          
            this.c = c;
        }

        public override string ToString()
        {
            return String.Format($"{a}, {b}, {c}");
        }
    }
}
