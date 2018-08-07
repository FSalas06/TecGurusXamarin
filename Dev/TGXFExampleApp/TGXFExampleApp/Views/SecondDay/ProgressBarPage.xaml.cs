using TGXFExampleApp.ViewModels.SecondDay;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TGXFExampleApp.Views.SecondDay
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgressBarPage : ContentPage
	{
        ProgressBarViewModel _viewModel;

        public ProgressBarPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new ProgressBarViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }
    }
}