using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGXFExampleApp.ViewModels.SecondDay;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TGXFExampleApp.Views.SecondDay
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondDayPage : ContentPage
	{
        SecondDayViewModel _viewModel;

        public SecondDayPage ()
		{
			InitializeComponent ();
            BindingContext = _viewModel = new SecondDayViewModel();
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