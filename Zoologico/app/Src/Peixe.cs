using app.Src.Interfaces;
using System;

namespace app.Src
{
    public class Peixe : Animal, IAquaticos
    {
        int Flippers { get; set; }

        public Peixe(string name, Classification tipo, string color, int age, int flippers) : base(name, tipo, color, age)
        {
            Flippers = flippers;
        }

    }
}