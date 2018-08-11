using System.Collections.ObjectModel;
using TGXFExampleApp.Models;
using TGXFExampleApp.Views.ExamplesApp;
using TGXFExampleApp.Views.FirstDay;
using TGXFExampleApp.Views.SecondDay;

namespace TGXFExampleApp.Views.Menu
{
    class MenuListData : ObservableCollection<MenuItemMaster>
    {
        public MenuListData()
        {
            this.Add(new MenuItemMaster
            {
                TitleOption = "Dia 1",
                IconSource = "devday.png",
                TargetType = typeof(FirstDayPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Dia 2",
                IconSource = "devday.png",
                TargetType = typeof(SecondDayPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Practica 1",
                IconSource = "devday.png",
                TargetType = typeof(CalculatorPage)
            });
        }
    }
}
