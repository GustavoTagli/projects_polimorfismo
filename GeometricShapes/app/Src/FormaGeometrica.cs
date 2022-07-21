using System;

namespace app.Src
{
    public class FormaGeometrica
    {
        int QtdAresta { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Area { get; set; }

        public FormaGeometrica(int qtdAresta, double _base, double altura, double area)
        {
            QtdAresta = qtdAresta;
            Base = _base;
            Altura = altura;
            Area = area;
        }
    }
}