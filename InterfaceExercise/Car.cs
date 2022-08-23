using System;

namespace InterfaceExercise
{
    internal class Car : IVechicle, ICompany
    {
        public Car()
        {
        }

        public string Brands { get; set; } = "Luxury";
        public string Logo { get; set; } = "SpeedMark";
        int IVechicle.Year { get; set; } = 2022;
        string IVechicle.Make { get; set; } = "McLaren";
        string IVechicle.Model { get; set; } = "GT";
        int IVechicle.Wheels { get; set; } = 4;
        string ICompany.TurnOn { get; set; }
        

      

        public void Engine()
        {
            Console.WriteLine($"There's no doubt this car has a beast {GetType().Name}");
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
