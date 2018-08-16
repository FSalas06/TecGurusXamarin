using System;
using System.Diagnostics;
using System.Windows.Input;
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

        public ProductDetailViewModel(SupermarketItems item)
        {
            Item = item;
            AddItemToList = new Command(HandleAction);
        }

        void HandleAction(object obj)
        {
            try
            {
                App.DB.Add(Item);
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Error " + ex.Message);
            }
        }

    }
}
