namespace _027_Mas_sobre_propiedades
{
    public class Prueba
    {
        

        //propiedad calculada
        private double precioCompra;
        private double precioVenta;
        public double PrecioVenta { get { return precioCompra * 1.30; } }

        public Prueba(double precioCompra)
        {
            this.precioCompra = precioCompra;
        }

        //Expression-bodied properties
        //Propiedades de expresion representada
        public double Impuesto => PrecioVenta * 0.16;


        //Version C# 7 permite el set
        private double descuento;
        public double Descuento
        {
            get => precioCompra * (1 - descuento);
            set => descuento = value / 100;
        }

        //Inicializador de propiedades
        public int Inventario { get; set; } = 30;

        //Accesibilidad
        private int garantia;
        public int Garantia
        {
            get => garantia;
            private set => garantia = value;
        }

        public void ponerGarantia(int password, int garantia)
        {
            if (password == 12345)
                Garantia = garantia;
        }
    }
}
