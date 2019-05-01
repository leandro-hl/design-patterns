namespace DesignPatternsApp.CommandPatternModule.Car
{
    public abstract class CarCommand : TransportCommand
    {
        public CarCommand()
        {
            this.TransportDescription = "Car";
        }
    }
}