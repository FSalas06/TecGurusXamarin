using TGXFExampleApp.ViewModels.ExampleApp.BarcodeScanner;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.BarcodeScanner
{
    public partial class BarcodePage : ContentPage
    {
        BarcodeViewModel _viewModel;

        public BarcodePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new BarcodeViewModel();
        }
    }
}
