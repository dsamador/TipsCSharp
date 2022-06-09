namespace _028_Clases_y_metodos_parciales
{
    partial class Ejemplo
    {
        public double Costo { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        // Definimos un metodo parcial
        // va a trabajar como si fuera un metodo privado
        // no se le puede colocar acceso ni modificadores.
        partial void calculaImpuesto(double impuesto);
    }
}
