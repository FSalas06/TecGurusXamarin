using TGXFExampleApp.ViewModels.SecondDay;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TGXFExampleApp.Views.SecondDay
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperPage : ContentPage
    {
        StepperViewModel _viewModel;

        public StepperPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new StepperViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }
    }
}