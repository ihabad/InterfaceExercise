namespace InterfaceExercise
{
    internal interface IVechicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }


        public void Engine();
        public void Gears();
        public void TurnOn();
    }
}
