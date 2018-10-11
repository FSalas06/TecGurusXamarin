using System;
using AppEjemplo.Model;
using Xamarin.Forms;

namespace AppEjemplo.Menu
{
    public class MasterDetail : MasterDetailPage
    {
        MasterPage masterPage;

        public MasterDetail()
        {
            masterPage = new MasterPage();
            Master = masterPage;
            Detail = new NavigationPage(new DetailPage());

            masterPage.listView.ItemSelected += OnItemSelected;

            masterPage.listView.ItemsSource = new MenuListData();
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MenuItemMaster item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
