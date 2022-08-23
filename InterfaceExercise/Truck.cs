using System;

namespace InterfaceExercise
{
    internal class Truck : IVechicle, ICompany
    {
        public Truck()
        {

        }
        public string Brands { get; set; } = "Hino";
        public string Logo { get; set; } = "three ovals";
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Pickup";
        public int Wheels { get; set; } = 4;
        string ICompany.TurnOn { get; set; }

        public void Engine()
        {
            Console.WriteLine($"There's no doubt this Truck has a beast {GetType().Name}");
        }

        public void Gears()
        {
            Console.WriteLine($"Moreover, it comes with multi- {GetType().Name} to make riding more comfortable ");
        }
        public void TurnOn()
        {
            Console.WriteLine($"The only thing you need to do is turn it on and go for a ride");
        }
    }
}
