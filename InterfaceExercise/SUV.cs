using System;

namespace InterfaceExercise
{
    internal class SUV : IVechicle, ICompany

    { 
        public SUV()
        {

        }

        public string caro { get; set; }
        public bool EightCylinder { get; set; }
        public string Brands { get; set; }
        public string Logo { get; set; }
        int IVechicle.Year { get; set; }
        string IVechicle.Make { get; set; }
        string IVechicle.Model { get; set; }
        int IVechicle.Wheels { get; set; }
        string ICompany.TurnOn { get; set; }

        public void Engine()
        {
            Console.WriteLine($"There's no doubt this SUV has a beast {GetType().Name}");
        }
        public void Gears()
        {
            Console.WriteLine($"Moreover, it comes with multi-{GetType().Name}  to make riding more comfortable");
        }
        public void TurnOn()
        {
            Console.WriteLine($"The only thing you need to do is turn it on and go for a ride");
        }
    }
}
