using System;


namespace app.Src
{
    public class Triangulo : FormaGeometrica
    {
        public Triangulo(int qtdAresta, double _base, double altura, double area) : base(qtdAresta, _base, altura, area)
        {
        }

        public double CalcularArea()
        {
            return Area = (Base * Altura) / 2;
        }
    }
}