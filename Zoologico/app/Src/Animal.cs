using System;

namespace app.Src
{
    public class Animal
    {
        public string Name { get; set; }
        public Classification Tipo { get; set;}
        public string Color { get; set; }
        public int Age { get; set; }

        public Animal(string name, Classification tipo, string color, int age)
        {
            Name = name;
            Tipo = tipo;
            Color = color;
            Age = age;
        }

        public virtual void Walk()
        {
            Console.WriteLine($"Eu, {Name}, estou caminhando...");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"Eu, {Name}, estou comendo nhamnham");
        }
        public virtual void Drink()
        {
            Console.WriteLine($"Eu, {Name}, estou bebendo água");
        }
        public void Sleep()
        {
            Console.WriteLine($"Eu, {Name}, estou durmindo ZzzZz");
        }
    }
    
    public enum Classification
    {
        TERRESTRE,
        AQUATICO,
        AEREO
    }
}