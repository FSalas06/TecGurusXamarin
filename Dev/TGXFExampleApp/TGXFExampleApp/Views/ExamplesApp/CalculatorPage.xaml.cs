using System;
using System.Collections.Generic;
using TGXFExampleApp.ViewModels.ExampleApp;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp
{
    public partial class CalculatorPage : ContentPage
    {
        CalculatorViewModel _viewModel;

        public CalculatorPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CalculatorViewModel();
        }
    }
}
