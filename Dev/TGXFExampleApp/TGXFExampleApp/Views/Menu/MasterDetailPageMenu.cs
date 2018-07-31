using System;
using Xamarin.Forms;
using TGXFExampleApp.Models;

namespace TGXFExampleApp.Views.Menu
{
    public class MasterDetailPageMenu : MasterDetailPage
    {
        MasterPageMenu masterPage;

        public MasterDetailPageMenu()
        {
            masterPage = new MasterPageMenu();
            Master = masterPage;
            Detail = new NavigationPage(new MasterDetailMenu());

            masterPage.listView.ItemSelected += OnItemSelected;

            masterPage.listView.ItemsSource = new MenuListData();
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MenuItemMaster item)
            {
                Detail.Navigation.PushAsync(new NavigationPage((Page)Activator.CreateInstance(item.TargetType)));
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
