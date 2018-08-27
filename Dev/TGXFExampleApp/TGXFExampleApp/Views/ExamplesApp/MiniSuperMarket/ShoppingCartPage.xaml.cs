using System;
using System.Collections.Generic;
using TGXFExampleApp.ViewModels.ExampleApp.MiniSuperMarket;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.MiniSuperMarket
{
    public partial class ShoppingCartPage : ContentPage
    {
        ShoppingCartViewModel _viewModel;

        public ShoppingCartPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new ShoppingCartViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }
    }
}
