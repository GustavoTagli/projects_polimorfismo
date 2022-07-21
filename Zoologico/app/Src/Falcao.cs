using app.Src.Interfaces;
using System;

namespace app.Src
{
    public class Falcao : Animal, IAereos
    {
        public Falcao(string name, Classification tipo, string color, int age) : base(name, tipo, color, age)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("Eu Falcão caço para comer");
        }
    }
}