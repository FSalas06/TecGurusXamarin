using System.Collections.ObjectModel;
using TGXFExampleApp.Models;
using TGXFExampleApp.Views.ExamplesApp;
using TGXFExampleApp.Views.ExamplesApp.BarcodeScanner;
using TGXFExampleApp.Views.ExamplesApp.DepedencyExample;
using TGXFExampleApp.Views.ExamplesApp.MiniSuperMarket;
using TGXFExampleApp.Views.ExamplesApp.RestServices;
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
                TitleOption = "User Interface 1",
                IconSource = "devday.png",
                TargetType = typeof(FirstDayPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "User Interface 2",
                IconSource = "devday.png",
                TargetType = typeof(SecondDayPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Practice 1",
                IconSource = "devday.png",
                TargetType = typeof(CalculatorPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Example 1 - Local Database (SQLite)",
                IconSource = "devday.png",
                TargetType = typeof(SuperMarketProductListPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Example 2 - Dependency and package",
                IconSource = "devday.png",
                TargetType = typeof(DependencyPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Example 3 - Rest API",
                IconSource = "devday.png",
                TargetType = typeof(AmiiboPage)
            });

            this.Add(new MenuItemMaster
            {
                TitleOption = "Example 4 - BarCode Scanner",
                IconSource = "devday.png",
                TargetType = typeof(BarcodePage)
            });
        }
    }
}
