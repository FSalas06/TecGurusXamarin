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
	public partial class ActivityIndicatorPagexaml : ContentPage
	{
        ActivityIndicatorViewModel _viewModel;

        public ActivityIndicatorPagexaml ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new ActivityIndicatorViewModel();

        }
	}
}