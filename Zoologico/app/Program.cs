using System;
using app.Src;
using app.Src.Interfaces;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var pluto = new Cachorro("Pluto", Classification.TERRESTRE, "Branco", 4);
            var roger = new Falcao("Roger", Classification.AEREO, "Branco com Marrom", 3);
            IAereos jorgin = new Flamingo("Jorgin", Classification.AEREO, "Rosa", 5);
            var simba = new Leao("Simba", Classification.TERRESTRE, "Bege", 10, ManeSize.Grande);
            IAquaticos nemo = new Peixe("Nemo", Classification.AQUATICO, "Laranja com Branco", 13, 2);

            pluto.Drink();
            pluto.Bark();

            roger.Hunt();

            jorgin.Fly();

            simba.Roar();

            nemo.Swim();
        }
    }
}
