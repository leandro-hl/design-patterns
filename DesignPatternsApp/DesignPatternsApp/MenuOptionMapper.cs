using DesignPatternsApp.CommandPatternModule;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsApp
{
    public static class MenuOptionMapper
    {
        public static IList<MenuOption> MapFromTransportCommands(IEnumerable<TransportCommand> transportCommands)
        {
            return transportCommands
                .Select(x => new MenuOption
                {
                    ApplyOptionTo = x.TransportDescription,
                    OptionDescription = x.CommandDescription,
                    OptionHandler = x.CommandCode
                })
                .ToList();
        }
    }
}