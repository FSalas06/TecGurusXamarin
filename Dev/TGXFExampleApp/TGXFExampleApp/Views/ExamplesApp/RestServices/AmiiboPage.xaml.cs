using TGXFExampleApp.ViewModels.ExampleApp.RestServices;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.RestServices
{
    public partial class AmiiboPage : ContentPage
    {
        AmiiboViewModel _viewModel;

        public AmiiboPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new AmiiboViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
