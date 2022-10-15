class Triangulo:Figura
{
        int lado1;
        int lado2;
        int lado3;

    public Triangulo( int l1, int l2, int l3)
    {
        lado1 = l1;
        lado2 = l2;
        lado3 = l3;
    }
      override public int perimetro()
    {
       int res = lado1+lado2+lado3;
       return res;
        
    }
}