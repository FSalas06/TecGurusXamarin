using System;
using System.Collections.ObjectModel;
using TGXFExampleApp.LocalData;
using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.Shared;

namespace TGXFExampleApp.ViewModels.ExampleApp.MiniSuperMarket
{
    public class ShoppingCartViewModel : BaseViewModel
    {
        private ObservableCollection<SupermarketItems> _shoppingList;

        public ObservableCollection <SupermarketItems> ShoppingList
        {
            get
            {
                return _shoppingList;
            }
            set
            {
                SetObservableProperty(ref _shoppingList, value);
            }
        }

        private ServicesDataBase<SupermarketItems> ServiceData;

        public ShoppingCartViewModel()
        {
            ServiceData = new ServicesDataBase<SupermarketItems>();
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            ShoppingList = new ObservableCollection<SupermarketItems>(await ServiceData.GetTableAsync());
        }
    }
}
