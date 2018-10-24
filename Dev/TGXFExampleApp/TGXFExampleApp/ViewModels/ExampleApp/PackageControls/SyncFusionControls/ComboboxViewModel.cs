using System;
using System.Collections.ObjectModel;
using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.Shared;
using TGXFExampleApp.Views;

namespace TGXFExampleApp.ViewModels.ExampleApp.PackageControls.SyncFusionControls
{
	public class ComboboxViewModel : BaseViewModel
    {
        private ObservableCollection<ComboboxItem> _itemsPicker;
        private ComboboxItem _pickerSelected;

        public ObservableCollection<ComboboxItem> ItemsPicker
        {
            get
            {
                return _itemsPicker;
            }
            set
            {
                SetObservableProperty(ref _itemsPicker, value);
            }
        }

        public ComboboxItem PickerSelected
        {
            get
            {
                return _pickerSelected;
            }
            set
            {
                SetObservableProperty(ref _pickerSelected, value);
            }
        }

        public ComboboxViewModel()
        {
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            LoadItemPicker();
        }

        private void LoadItemPicker()
        {
            ItemsPicker = new ObservableCollection<ComboboxItem>(OptionItems.PickerListItems());
        }
    }
}
