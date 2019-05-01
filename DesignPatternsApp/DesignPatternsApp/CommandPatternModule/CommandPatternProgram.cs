﻿using DesignPatternsApp.CommandPatternModule.Car;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsApp.CommandPatternModule
{
    public static class CommandPatternProgram
    {
        public static void Init()
        {
            //My Commands
            var carCommands = new List<TransportCommand>
            {
                new StartCarCommand(),
                new CleanCarCommand(),
                new StopCarCommand()
            };

            //Create Menu Options List
            var menuOptions = MenuOptionMapper.MapFromTransportCommands(carCommands);

            //Create Menu Builder
            var menuBuilder = new MenuBuilder();
            menuBuilder.ForOptions(menuOptions);

            //Create UIComponentBundle
            var uiComponentBundle = new UIComponentBundle(menuBuilder);

            //Create Artist
            var artist = new Artist(uiComponentBundle);

            //Paint UI
            artist.Paint(UIComponent.Header);
            artist.Paint(UIComponent.Menu);

            //Handle commands
            do
            {                
                var pressedKey = Console.ReadKey().KeyChar.ToString();

                if (int.TryParse(pressedKey, out int commandKey))
                {
                    var commandsToExecute = carCommands
                        .Where(x => x.CommandCode == commandKey)
                        .ToList();

                    commandsToExecute.ForEach(x => x.Execute());
                }
                else
                {
                    break;
                }
            } while (true);            
        }
    }
}