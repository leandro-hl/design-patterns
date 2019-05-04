using DesignPatternsApp.UI;
using System;

namespace DesignPatternsApp
{
    public class UIComponentBundle : IUIComponentBundle
    {
        private readonly IMenuBuilder menuBuilder;

        public UIComponentBundle(IMenuBuilder menuBuilder)
        {
            this.menuBuilder = menuBuilder;
        }

        public void CreateHeader()
        {
            Console.WriteLine(
                "***********************\n" +
                "**      Welcome!     **\n" +
                "***********************\n");
        }

        public void CreateMenu()
        {
            this.menuBuilder.Build();
        }
    }
}