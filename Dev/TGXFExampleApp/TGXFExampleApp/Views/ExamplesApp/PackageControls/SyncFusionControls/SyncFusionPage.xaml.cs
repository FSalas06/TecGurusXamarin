using TGXFExampleApp.ViewModels.ExampleApp.PackageControls.SyncFusionControls;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.PackageControls.SyncFusionControls
{
    public partial class SyncFusionPage : ContentPage
    {
        SyncFusionViewModel _viewModel;

        public SyncFusionPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SyncFusionViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
