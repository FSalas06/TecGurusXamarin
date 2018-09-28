using System;
using System.Collections.Generic;
using TGXFExampleApp.ViewModels.ExampleApp.DependencyExample;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.DepedencyExample
{
    public partial class DependencyPage : ContentPage
    {
        DependencyViewModel _viewModel;

        public DependencyPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new DependencyViewModel();
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
