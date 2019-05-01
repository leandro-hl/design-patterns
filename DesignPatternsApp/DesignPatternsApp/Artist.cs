namespace DesignPatternsApp
{
    public class Artist
    {
        private readonly UIComponentBundle uIComponentBundle;

        public Artist(UIComponentBundle uIComponentBundle)
        {
            this.uIComponentBundle = uIComponentBundle;
        }

        public void Paint(UIComponent uiComponentToPaint)
        {
            switch (uiComponentToPaint)
            {
                case UIComponent.Header:
                    this.uIComponentBundle.CreateHeader();
                    break;

                case UIComponent.Menu:
                    this.uIComponentBundle.CreateMenu();
                    break;
            }
        }
    }

    public enum UIComponent
    {
        Header,
        Menu
    }
}