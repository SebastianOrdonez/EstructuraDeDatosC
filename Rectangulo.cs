// Clase Rectangulo
public class Rectangulo
{
    private double ancho;
    private double alto;

    // Constructor
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // Método para calcular el área (ancho * alto)
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // Método para calcular el perímetro (2 * (ancho + alto))
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}