using TGXFExampleApp.ViewModels.FirstDay;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.FirstDay
{
    public partial class ButtonPage : ContentPage
    {
        ButtonViewModel _viewModel;

        public ButtonPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new ButtonViewModel();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}
