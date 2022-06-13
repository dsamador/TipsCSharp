namespace _033_Restricciones_a_clases_genericas
{
    // where base-class, T debe ser una subclase de una clase en particular
    // where T: clase-base
    // where T: clase
    // where T: interfaz
    // where T: struct
    // where T: new()
    public class Generica<T> where T : new()
    {
        T objeto;
        public Generica(T objeto)
        {
            this.objeto = objeto;
        }
        public void Repetir()
        {
            int n;
            for (n = 0; n < 5; n++)
                Console.WriteLine(objeto);                        
        }
    }
}
