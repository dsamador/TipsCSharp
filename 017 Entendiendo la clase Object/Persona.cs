using System;

namespace _017_Entendiendo_la_clase_Object
{
    public class Persona: Object
    {
        private string nombre;
        private int edad;
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
