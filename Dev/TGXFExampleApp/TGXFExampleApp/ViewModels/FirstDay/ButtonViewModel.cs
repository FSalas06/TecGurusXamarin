using System;
using System.Windows.Input;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.FirstDay
{
    public class ButtonViewModel : BaseViewModel
    {
        public ICommand AlertShowCommand { get; private set; }
        public ICommand ActionSheetCommand { get; private set; }
        public ICommand YesNoAlertCommand { get; private set; }

        public ButtonViewModel()
        {
            AlertShowCommand = new Command(ShowAlertAction);
            ActionSheetCommand = new Command(ShowActionSheet);
            YesNoAlertCommand = new Command(ShowYesNoAlert);
        }

        private async void ShowYesNoAlert(object obj)
        {
            var answer = await DisplayYesNoAlert(message: "Do you like to continue?");
            DisplayAlert(message: "You select : " + (answer ? "Yes" : "No"));
            if(!answer)
            {
                await App.Navigation.PopToRootAsync(true);
            }
        }

        private async void ShowActionSheet(object obj)
        {
            string[] options = { "Option1", "Option2", "Option3" };
            var select = await DisplayActionSheetAlert(options: options);

            DisplayAlert(message: "You Selects :" + select);
        }

        private void ShowAlertAction(object obj)
        {
            DisplayAlert(message: "Hello it is an Alert!");
        }
    }
}
