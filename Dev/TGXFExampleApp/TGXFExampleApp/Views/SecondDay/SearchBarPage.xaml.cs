using System;
using System.Collections.Generic;
using TGXFExampleApp.ViewModels.SecondDay;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.SecondDay
{
    public partial class SearchBarPage : ContentPage
    {
        SearchBarViewModel _viewModel;

        public SearchBarPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new SearchBarViewModel();
        }
    }
}
