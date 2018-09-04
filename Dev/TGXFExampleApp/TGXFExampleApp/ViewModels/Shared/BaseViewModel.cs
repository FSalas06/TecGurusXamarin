using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.Shared
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                SetObservableProperty(ref _isBusy, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual async void OnAppearing()
        {

        }

        public virtual async void OnDissappearing()
        {

        }

        protected void OnPropertyChanged([CallerMemberName] string property = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        protected void SetObservableProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            field = value;
            OnPropertyChanged(propertyName);
        }

        #region Alerts
        public async void DisplayAlert(string title = Constants.NameApp, string message = "", string okText = "Ok")
        {
			await Application.Current.MainPage.DisplayAlert(title, message, okText);
        }

        public async Task<bool> DisplayYesNoAlert(string title = Constants.NameApp, string message = "", string YesText = "Yes", string noText = "No")
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, YesText, noText);
        }

        public async Task<string> DisplayActionSheetAlert(string title = Constants.NameApp, string cancel = "cancel", string dest = "ok", params string[] options)
        {
            return await Application.Current.MainPage.DisplayActionSheet(title, cancel, dest, options);
        }
        #endregion
    }
}
