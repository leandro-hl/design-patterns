using System;
using System.Collections.Generic;

namespace DesignPatternsApp.UI.Imp
{
    public class AnotherMenuBuilder : IMenuBuilder
    {
        private IList<MenuOption> menuOptions;

        public AnotherMenuBuilder()
        {
            this.menuOptions = new List<MenuOption>();
        }

        public void ForOptions(IList<MenuOption> menuOptions)
        {
            foreach (var menuOption in menuOptions)
            {
                this.menuOptions.Add(menuOption);
            }
        }

        public void Build()
        {
            Console.WriteLine($"There are: { this.menuOptions.Count } options");
        }
    }
}