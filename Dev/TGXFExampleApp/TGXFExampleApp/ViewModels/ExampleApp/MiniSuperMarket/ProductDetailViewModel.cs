using System;
using System.Diagnostics;
using System.Windows.Input;
using TGXFExampleApp.LocalData;
using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.ExampleApp.MiniSuperMarket
{
    public class ProductDetailViewModel : BaseViewModel
    {
        private SupermarketItems _item;
        public SupermarketItems Item
        {
            get
            {
                return _item;
            }
            set
            {
                SetObservableProperty(ref _item, value);
            }
        }

        public ICommand AddItemToList { get; private set; }
        private ServicesDataBase<SupermarketItems> ServiceData;

        public ProductDetailViewModel(SupermarketItems item)
        {
            Item = item;
            ServiceData = new ServicesDataBase<SupermarketItems>();
            AddItemToList = new Command(HandleAction);
        }

        private async void HandleAction(object obj)
        {
            try
            {
                await ServiceData.AddToTableAsync(Item);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Error " + ex.Message);
            }
        }

    }
}
