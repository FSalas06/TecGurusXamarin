using System;
using Xamarin.Forms;

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
        }
    }
}
