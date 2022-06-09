namespace _028_Clases_y_metodos_parciales
{
    partial class Ejemplo
    {
        public override string ToString()
        {
            calculaImpuesto(0.16);
            return string.Format($"El costo es {Costo}, " +
                $"el impuesto {Impuesto}, el total es {Total}");
        }

        // Implementamos el metodo parcial
        partial void calculaImpuesto(double impuesto)
        {
            Impuesto = Costo * impuesto;
            Total = Costo + Impuesto;
        }
    }
}