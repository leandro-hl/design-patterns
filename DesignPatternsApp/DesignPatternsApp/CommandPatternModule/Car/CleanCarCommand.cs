using System;

namespace DesignPatternsApp.CommandPatternModule.Car
{
    public class CleanCarCommand : CarCommand
    {
        public CleanCarCommand()
        {
            this.CommandDescription = "Clean";
            this.CommandCode = 2;
        }

        public override void Execute()
        {
            Console.WriteLine("\nCar cleaned!...\n");
        }
    }
}