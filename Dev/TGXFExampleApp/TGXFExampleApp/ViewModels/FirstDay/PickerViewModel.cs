using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TGXFExampleApp.ViewModels.Shared;
using TGXFExampleApp.Views;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.FirstDay
{
    public class PickerViewModel : BaseViewModel
    {
        private ObservableCollection<string> _pickerListItem;
        private int _itemPickerIndex;

        public ObservableCollection<string> PickerListItem
        {
            get
            {
                return _pickerListItem;
            }
            set
            {
                SetObservableProperty(ref _pickerListItem, value);
            }
        }

        public int ItemPickerIndex
        {
            get
            {
                return _itemPickerIndex;
            }
            set
            {
                SetObservableProperty(ref _itemPickerIndex, value);
                if (PickerIndexCommend.CanExecute(_itemPickerIndex))
                {
                    PickerIndexCommend.Execute(_itemPickerIndex);
                }
            }
        }

        public ICommand SelectedItemPicker { get; private set; }
        public ICommand PickerIndexCommend { get; private set; }

        public PickerViewModel()
        {
            PickerListItem = new ObservableCollection<string>();
            PickerIndexCommend = new Command<int>(PickerIndex);
        }

        private void PickerIndex(int obj)
        {
            
        }

        private void ItemPickerMod(string obj)
        {
            
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            FillPickerPage();
        }

        private void FillPickerPage()
        {
            foreach (var valItem in OptionItems.OptionPickerItem().Keys)
            {
                PickerListItem.Add(valItem);
            }
        }
    }
}
