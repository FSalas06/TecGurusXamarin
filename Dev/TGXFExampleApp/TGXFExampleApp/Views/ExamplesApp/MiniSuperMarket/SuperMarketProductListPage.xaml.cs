using System;
using System.Collections.Generic;
using TGXFExampleApp.ViewModels.ExampleApp.MiniSuperMarket;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.MiniSuperMarket
{
    public partial class SuperMarketProductListPage : ContentPage
    {
        SuperMarketProductListViewModel _viewModel;

        public SuperMarketProductListPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SuperMarketProductListViewModel();
        }
    }
}
