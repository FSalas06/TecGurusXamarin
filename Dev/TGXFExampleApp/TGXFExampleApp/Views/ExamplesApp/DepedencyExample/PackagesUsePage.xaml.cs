using TGXFExampleApp.ViewModels.ExampleApp.DependencyExample;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.DepedencyExample
{
    public partial class PackagesUsePage : ContentPage
    {
        PackagesUseViewModel _viewModel;

        public PackagesUsePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new PackagesUseViewModel();
        }
    }
}
