namespace _033_Restricciones_a_clases_genericas
{
    public class A
    {
        public override string ToString()
        => string.Format("Desde la clase A");        
    }
    public class B : A
    {
        public override string ToString()
        {
            string r = base.ToString();
            return string.Format($"Desde la clase B -> {r}");
        }
    }
    public interface Interfaz
    {
        void metodo();
    }
    public class C : Interfaz
    {
        public void metodo()
        =>Console.WriteLine("Implementacion de la interfaz");        
        public override string ToString()
        => string.Format($"Desde la clase C");        
    }
}
