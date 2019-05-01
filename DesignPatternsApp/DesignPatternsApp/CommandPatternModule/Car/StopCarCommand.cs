using System;

namespace DesignPatternsApp.CommandPatternModule.Car
{
    public class StopCarCommand : CarCommand
    {
        public StopCarCommand()
        {
            this.CommandDescription = "Stop";
            this.CommandCode = 3;
        }

        public override void Execute()
        {
            Console.WriteLine("\nCar stopped!...\n");
        }
    }
}