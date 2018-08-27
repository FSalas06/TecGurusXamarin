using TGXFExampleApp.Models;
using TGXFExampleApp.ViewModels.ExampleApp.MiniSuperMarket;
using Xamarin.Forms;

namespace TGXFExampleApp.Views.ExamplesApp.MiniSuperMarket
{
    public partial class ProductDetailPage : ContentPage
    {
        ProductDetailViewModel _viewModel;

        public ProductDetailPage(SupermarketItems Item)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _viewModel = new ProductDetailViewModel(Item);
        }
    }
}
