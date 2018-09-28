using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.Shared;
using TGXFExampleApp.Views;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.FirstDay
{
    public class FirstDayViewModel : BaseViewModel
    {
        private ObservableCollection<OptionsItemMenu> _menuOptions;
        private OptionsItemMenu _singleOption;

        public OptionsItemMenu SingleOption
        {
            get
            {
                return _singleOption;
            }
            set
            {
                SetObservableProperty(ref _singleOption, value);
                if (_singleOption == null)
                {
                    return;
                }
                if(SelectedOption.CanExecute(_singleOption))
                {
                    SelectedOption.Execute(_singleOption);
                }
            }
        }

        public ObservableCollection<OptionsItemMenu> MenuOptions
        {
            get
            {
                return _menuOptions;
            }
            set
            {

                SetObservableProperty(ref _menuOptions, value);
            }
        }

        public ICommand SelectedOption { get; set; }

        public FirstDayViewModel()
        {
            MenuOptions = new ObservableCollection<OptionsItemMenu>();
            SelectedOption = new Command<OptionsItemMenu>(OptionSelected);
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            LoadFirstDay();
        }

        private void LoadFirstDay()
        {
            try
            {
                MenuOptions = OptionItems.OptionMenuItems(0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[LoadFirstDay] : " + ex.Message);
            }
        }

        private async void OptionSelected(OptionsItemMenu opt)
        {
            try
            {
                var page = (Page)Activator.CreateInstance(opt.TargetType);
                await (Application.Current.MainPage as MasterDetailPage).Detail.Navigation.PushAsync(new NavigationPage(page));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[OptionSelected] : " + ex.Message);
            }
        }
    }
}
