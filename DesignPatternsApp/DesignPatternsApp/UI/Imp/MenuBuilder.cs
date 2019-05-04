using DesignPatternsApp.UI;
using System;
using System.Collections.Generic;

namespace DesignPatternsApp
{
    public class MenuBuilder : IMenuBuilder
    {
        private IList<MenuOption> menuOptions;

        public MenuBuilder()
        {
            this.menuOptions = new List<MenuOption>();
        }

        public void ForOptions(IList<MenuOption> menuOptions)
        {
            this.menuOptions = menuOptions;
        }

        public void Build()
        {
            foreach (var menuOption in this.menuOptions)
            {
                Console.WriteLine(
                    $"-> Press ( { menuOption.OptionHandler } ) " +
                    $"to { menuOption.OptionDescription } " +
                    $"the { menuOption.ApplyOptionTo }.\n");
            }
        }
    }
}