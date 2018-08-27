using System;
using System.Collections.Generic;
using System.IO;
using TGXFExampleApp.Interfaces;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.DepedencyExample
{
    public partial class PickerImagePage : ContentPage
    {
        public PickerImagePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void Handle_Clicked(object sender, EventArgs e)
        {
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

            if (stream != null)
            {
                _imagePicker.Source = ImageSource.FromStream(() => stream);
                _imagePicker.BackgroundColor = Color.Gray;
            }
        }
    }
}
