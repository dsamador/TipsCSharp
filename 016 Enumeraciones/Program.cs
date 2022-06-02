string dato = "";
double tamanoImg = 0.0;

Console.WriteLine("Dame la dimension de la imagen");
dato = Console.ReadLine();
tamanoImg = Convert.ToDouble(dato);

calcularEspacio(tipoImagen., tamanoImg);

static void calcularEspacio(tipoImagen imagen, double tamanoImg)
{
    double espacio = 0;
    switch (imagen)
    {
        case tipoImagen.BMP:
            espacio = tamanoImg * 1.1;
            break;
        case tipoImagen.JPG:
            espacio = tamanoImg * 0.8;
            break;
        case tipoImagen.PNG:
            espacio = tamanoImg * 0.77;
            break;
        case tipoImagen.GIF:
            espacio = tamanoImg * 1.5;
            break;
        case tipoImagen.TIFF:
            espacio = tamanoImg * 0.97;
            break;
    }

    Console.WriteLine($"La dimension final es {espacio}");
}
enum tipoImagen { BMP = 15, JPG, PNG, GIF, TIFF }; 