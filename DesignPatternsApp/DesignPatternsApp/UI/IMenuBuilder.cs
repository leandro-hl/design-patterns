using System.Collections.Generic;

namespace DesignPatternsApp.UI
{
public interface IMenuBuilder
{
    void ForOptions(IList<MenuOption> menuOptions);

    void Build();
}
}