using System;
using System.Collections.Generic;
using System.Windows.Input;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace TGXFExampleApp.ViewModels.ExampleApp.BarcodeScanner
{
    public class BarcodeViewModel : BaseViewModel
    {
        private string _result;
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand ButtonCommand { get; private set; }

        public BarcodeViewModel()
        {
            ButtonCommand = new Command(OnButtomCommand);
        }

        private void OnButtomCommand()
        {
            var options = new MobileBarcodeScanningOptions
            {
                PossibleFormats = new List<BarcodeFormat>
                {
                    BarcodeFormat.QR_CODE,
                    BarcodeFormat.CODE_128,
                    BarcodeFormat.EAN_13
                }
            };
            var page = new ZXingScannerPage(options) { Title = "Scanner" };
            var closeItem = new ToolbarItem { Text = "Close" };
            closeItem.Clicked += (object sender, EventArgs e) =>
            {
                page.IsScanning = false;
                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                });
            };
            page.ToolbarItems.Add(closeItem);
            page.OnScanResult += (result) =>
            {
                page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    if (string.IsNullOrEmpty(result.Text))
                    {
                        Result = "No valid code has been scanned";
                    }
                    else
                    {
                        Result = $"Result: {result.Text}";
                    }
                });
            };
            Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(page) { BarTextColor = Color.White, BarBackgroundColor = Color.CadetBlue }, true);
        }
    }
}
