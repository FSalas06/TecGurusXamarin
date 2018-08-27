using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TGXFExampleApp.LocalData;
using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

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

        public ICommand OnDeleteCommand { get; private set; }

        public ShoppingCartViewModel()
        {
            ServiceData = new ServicesDataBase<SupermarketItems>();
            OnDeleteCommand = new Command<SupermarketItems>(OnDeleteCommandExecute);
        }

        private async void OnDeleteCommandExecute(SupermarketItems itm)
        {
            await ServiceData.DeleteById(itm.Id);
            ShoppingList.Remove(itm);
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            ShoppingList = new ObservableCollection<SupermarketItems>(await ServiceData.GetTableAsync());
        }
    }
}
