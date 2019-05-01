using System;

namespace DesignPatternsApp
{
    public class UIComponentBundle
    {
        private readonly MenuBuilder menuBuilder;

        public UIComponentBundle(MenuBuilder menuBuilder)
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