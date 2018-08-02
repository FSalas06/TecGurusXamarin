using System;
using System.Collections.Generic;
using TGXFExampleApp.ViewModels.FirstDay;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.FirstDay
{
    public partial class PickerPage : ContentPage
    {
        PickerViewModel _viewModel;

        public PickerPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new PickerViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel?.OnAppearing();
        }
    }
}
