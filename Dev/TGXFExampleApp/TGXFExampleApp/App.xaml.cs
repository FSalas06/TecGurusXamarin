using TGXFExampleApp.LocalData;
using TGXFExampleApp.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TGXFExampleApp
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; set; }
        

        public App()
        {
            //#if DEBUG
            //LiveReload.Init();
            //#endif

            InitializeComponent();
            MainPage = new MasterDetailPageMenu();
            Navigation = (Current.MainPage as MasterDetailPage).Detail.Navigation;
        }

        private static DataBaseContext _db;
        public static DataBaseContext DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new DataBaseContext();
                }
                return _db;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
