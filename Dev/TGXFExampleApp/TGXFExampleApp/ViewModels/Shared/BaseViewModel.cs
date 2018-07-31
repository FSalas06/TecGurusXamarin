using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.Shared
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }

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
    }
}
