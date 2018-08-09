using TGXFExampleApp.ViewModels.FirstDay;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.FirstDay
{
    public partial class FirstDayPage : ContentPage
	{
        FirstDayViewModel _viewModel;

		public FirstDayPage ()
		{
			InitializeComponent ();
            BindingContext = _viewModel = new FirstDayViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}