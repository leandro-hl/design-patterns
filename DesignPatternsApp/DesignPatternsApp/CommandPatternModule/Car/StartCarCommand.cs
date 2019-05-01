using System;

namespace DesignPatternsApp.CommandPatternModule.Car
{
    public class StartCarCommand : CarCommand
    {
        public StartCarCommand()
        {
            this.CommandDescription = "Start";
            this.CommandCode = 1;
        }

        public override void Execute()
        {
            Console.WriteLine("\nCar started!...\n");
        }
    }
}