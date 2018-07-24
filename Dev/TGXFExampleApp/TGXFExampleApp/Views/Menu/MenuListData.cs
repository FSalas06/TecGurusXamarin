using System.Collections.ObjectModel;
using TGXFExampleApp.Models;
using TGXFExampleApp.Views.FirstDay;

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
        }
    }
}
