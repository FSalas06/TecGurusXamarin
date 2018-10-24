using System.Threading.Tasks;
using Xamarin.Forms;

namespace TGXFExampleApp.Common.Controls
{
    public partial class CustomButton : ContentView
    {
        public CustomButton()
        {
            InitializeComponent();
            btn_loading.Text = "Make Transfer";
            a_load.IsVisible = false;
            a_load.IsRunning = false;
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(a_load.IsRunning)
            {
                return;
            }
            btn_loading.BackgroundColor = Color.FromHex("#0ea152");
            f_btn.BackgroundColor = Color.FromHex("#0ea152");
            a_load.IsVisible = true;
            a_load.IsRunning = true;
            btn_loading.Text = "Loading...";
            await Task.Delay(8000);
            a_load.IsVisible = false;
            a_load.IsRunning = false;
            btn_loading.BackgroundColor = Color.Red;
            f_btn.BackgroundColor = Color.Red;
            btn_loading.Text = "Fail";
        }
    }
}
