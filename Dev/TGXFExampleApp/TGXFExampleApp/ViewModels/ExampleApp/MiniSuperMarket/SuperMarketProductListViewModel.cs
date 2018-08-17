using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.Shared;
using TGXFExampleApp.Views;
using TGXFExampleApp.Views.ExamplesApp.MiniSuperMarket;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.ExampleApp.MiniSuperMarket
{
    public class SuperMarketProductListViewModel : BaseViewModel
    {
        private ObservableCollection<SupermarketItems> _supermarketListItems;
        private SupermarketItems _item;

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

        public SupermarketItems Item
        {
            get
            {
                return _item;
            }
            set
            {
                SetObservableProperty(ref _item, value);
                if(GoToProductDescription.CanExecute(_item))
                {
                    if (_item != null)
                    {
                        GoToProductDescription.Execute(_item);
                    }
                }
            }
        }

        public ICommand GoToProductDescription { get; private set; }
        public ICommand GoCartCommand { get; private set; }

        public SuperMarketProductListViewModel()
        {
            SupermarketListItems = new ObservableCollection<SupermarketItems>(OptionItems.SuperMarketList());
            GoToProductDescription = new Command<SupermarketItems>(GoToDetail);
            GoCartCommand = new Command(OnGoToCartShopping);
        }

        private async void OnGoToCartShopping(object obj)
        {
            await (Application.Current.MainPage as MasterDetailPage).Detail.Navigation.PushAsync(new NavigationPage(new ShoppingCartPage()));
        }

        private async void GoToDetail(SupermarketItems item)
        {
            await (Application.Current.MainPage as MasterDetailPage).Detail.Navigation.PushAsync(new NavigationPage(new ProductDetailPage(item)));
        }


    }
}
