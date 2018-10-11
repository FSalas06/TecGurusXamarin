using System;
using System.Collections.ObjectModel;
using AppEjemplo.Model;

namespace AppEjemplo.Menu
{
    public class MenuListData : ObservableCollection<MenuItemMaster>
    {
        public MenuListData()
        {
            this.Add(new MenuItemMaster
            {
                TitleOption = "CalculatorPage",
                IconSource = "devapp.png",
                TargetType = typeof(CalculatorPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "CalculatorPage2",
                IconSource = "devapp.png",
                TargetType = typeof(CalculatorPage2)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Page Example",
                IconSource = "devapp.png",
                TargetType = typeof(PageExample)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "SingleButtonNavigation",
                IconSource = "devapp.png",
                TargetType = typeof(SingleButtonNavigation)
            });
        }
    }
}
