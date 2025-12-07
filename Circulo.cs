using System;

// Clase Circulo
public class Circulo
{
    private double radio;

    // Constructor
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área (π * r²)
    public double CalcularArea()
    {
        // Se utiliza Math.Pow(radio, 2) para elevar el radio al cuadrado
        return Math.PI * Math.Pow(radio, 2); 
    }

    // Método para calcular el perímetro (2 * π * r)
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}