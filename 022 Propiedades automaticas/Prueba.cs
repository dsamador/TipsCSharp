using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Propiedades_automaticas
{
    public class Prueba
    {
        //atributo privado
        private int valor;
        
        // propiedad tradicional
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        //Propiedad automatica
        public int Costo { get; set; } = 5;

        public void MuestraDatos()
        {
            Console.WriteLine($"Valor es = {valor}, costo es {Costo}");
        }
    }
}
