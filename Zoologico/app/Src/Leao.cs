using System;

namespace app.Src
{
    public class Leao : Animal
    {
        ManeSize Mane { get; set; }

        public Leao(string name, Classification tipo, string color, int age, ManeSize mane) : base(name, tipo, color, age)
        {
            Mane = mane;
        }


        public void Roar()
        {
            Console.WriteLine("Eu sou Leão grrrr");
        }

    }

    public enum ManeSize
    {
        Enorme,
        Grande,
        Médio,
        Pequeno,
        Nenhuma
    }
}