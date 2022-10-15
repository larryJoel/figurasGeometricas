internal class Program
    {
        static void Main(string[] args)
        {
        var figuras = new Figura[3];

        figuras[0]=new Rectangulo(10,4);
        figuras[1]=new Rectangulo(18,12);
        figuras[2]=new Triangulo(3,5,4);
        foreach (Figura f in figuras)
        {
            Console.WriteLine("El perimetro es:"+f.perimetro()); 
        }
    }
    }
