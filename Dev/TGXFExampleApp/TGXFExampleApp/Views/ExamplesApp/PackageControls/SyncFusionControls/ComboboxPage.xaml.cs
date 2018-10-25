using System;
using System.Collections.Generic;
using TGXFExampleApp.ViewModels.ExampleApp.PackageControls.SyncFusionControls;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.PackageControls.SyncFusionControls
{
    public partial class ComboboxPage : ContentPage
    {
        private ComboboxViewModel _viewModel;

        public ComboboxPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new ComboboxViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }
    }
}
