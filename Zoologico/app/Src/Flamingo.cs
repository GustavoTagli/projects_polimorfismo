using app.Src.Interfaces;
using System;

namespace app.Src
{
    public class Flamingo : Animal, IAereos
    {
        public Flamingo(string name, Classification tipo, string color, int age) : base(name, tipo, color, age)
        {
        }

        public override void Walk()
        {
            Console.WriteLine("Eu Flamingo caminho voando");
        }
    }
}