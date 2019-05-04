using DesignPatternsApp;
using DesignPatternsApp.UI;
using Moq;
using Xunit;

namespace Testing
{
    public class UIComponentBundleTest
    {
        private readonly Mock<IMenuBuilder> menuBuilder;

        private readonly UIComponentBundle uIComponentBundle;

        public UIComponentBundleTest()
        {
            this.menuBuilder = new Mock<IMenuBuilder>();

            this.uIComponentBundle = new UIComponentBundle(
                this.menuBuilder.Object);
        }

        [Fact]
        public void When_CreateMenuIsCalled_Should_DelegateToTheMenuBuilder()
        {
            //Setup

            //Act
            this.uIComponentBundle.CreateMenu();

            //Assert
            this.menuBuilder.Verify(
                x => x.Build(),
                Times.Once);
        }
    }
}