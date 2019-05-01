using System;

namespace DesignPatternsApp.CommandPatternModule
{
    public abstract class TransportCommand : ICommand
    {
        public string CommandDescription { get; set; }
        public int CommandCode { get; set; }
        public string TransportDescription { get; set; }

        public virtual void Execute()
        {
            throw new NotImplementedException();
        }
    }
}