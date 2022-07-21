using System;

namespace app.Src
{
    public class Cachorro : Animal
    {
        public Cachorro(string name, Classification tipo, string color, int age) : base(name, tipo, color, age)
        {
        }

        public override void Drink()
        {
            Console.WriteLine("Eu cachorro me lambuso todo bebendo água");
        }
        public void Bark()
        {
            Console.WriteLine("au au au");
        }
    }
}