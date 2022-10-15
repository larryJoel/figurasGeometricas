class Rectangulo: Figura{
    int bas;
    int altura;

    public Rectangulo(int bas,int altura)
    {
        this.bas = bas;
        this.altura = altura;
    }


    public override int perimetro()
    {
        int res= (2*bas)+(2*altura);
        return res;
    }
}