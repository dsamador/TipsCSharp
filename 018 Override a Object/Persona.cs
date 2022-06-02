using System.Text;

namespace _018_Override_a_Object
{
    public class Persona : Object
    {
        private string nombre;
        private int edad;
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            //esto no funciona
            //return Console.WriteLine($"Nombre: {nombre}, edad: {edad}");
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {nombre}, edad: {edad}");
            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if(obj != null && obj is Persona)
            {
                Persona temp = (Persona)obj;
                if(nombre == temp.nombre && edad == temp.edad)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return nombre.GetHashCode() + edad.GetHashCode();
        }
    }
}
