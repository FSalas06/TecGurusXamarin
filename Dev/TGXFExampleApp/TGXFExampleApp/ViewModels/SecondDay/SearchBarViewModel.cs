using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.Shared;
using TGXFExampleApp.Views;
using Xamarin.Forms;
using System.Linq;

namespace TGXFExampleApp.ViewModels.SecondDay
{
    public class SearchBarViewModel : BaseViewModel
    {
        private string _searchBarText;
        public ObservableCollection<SupermarketItems> _supermarketListItems;

        public ObservableCollection<SupermarketItems> SupermarketListItems
        {
            get 
            {
                return _supermarketListItems;
            }
            set
            {
                SetObservableProperty(ref _supermarketListItems, value);
            }
        }
        public string SearchBarText
        {
            get 
            {
                return _searchBarText;
            }
            set
            {
                SetObservableProperty(ref _searchBarText, value);
                if (FilterCommand.CanExecute(_searchBarText))
                {
                    FilterCommand.Execute(_searchBarText);
                }
            }
        }



        public ICommand FilterCommand { get; private set; }

        public SearchBarViewModel()
        {
            FilterCommand = new Command<string>(OnFilter);
            SupermarketListItems = new ObservableCollection<SupermarketItems>(OptionItems.SuperMarketList());
        }

        private void OnFilter(string filter)
        {
            SupermarketListItems = new ObservableCollection<SupermarketItems>(OptionItems.SuperMarketList().Where(st=> st.Name == filter));
        }
    }
}
