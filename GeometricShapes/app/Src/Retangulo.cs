using System;

namespace app.Src
{
    internal class Retangulo : FormaGeometrica
    {
        public Retangulo(int qtdAresta, double _base, double altura, double area) : base(qtdAresta, _base, altura, area)
        {
        }

        public double CalcularArea()
        {
            return Area = Base * Altura;
        }
    }
}
