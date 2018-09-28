using TGXFExampleApp.ViewModels.Menu;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.Menu
{
    public partial class MasterDetailMenu : ContentPage
    {        
        public MasterDetailMenu()
        {
            InitializeComponent();
            BindingContext = new MasterDetailMenuViewModel();
        }
    }
}
