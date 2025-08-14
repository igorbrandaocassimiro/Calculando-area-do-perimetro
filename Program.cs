using System;
class Program
{
    static void Main(string[] arge)
    {
        double raio = 5.0;  
        double pi = 3.14159; 

        double area = pi * raio * raio;  
        double perimetro = 2 * pi * raio; 

        Console.WriteLine("Raio: " + raio.ToString("F2"));  
        Console.WriteLine("Área do círculo: " + area.ToString("F2"));  
        Console.WriteLine("Perímetro do círculo: " + perimetro.ToString("F2")); 
    }
}