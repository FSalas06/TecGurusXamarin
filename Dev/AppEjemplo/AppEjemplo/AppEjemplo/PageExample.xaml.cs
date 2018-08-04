using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEjemplo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageExample : ContentPage
	{
        int sum = 0;

		public PageExample ()
		{
			InitializeComponent ();
		}
        

        private void btn1_Clicked(object sender, EventArgs e)
        {
            lb1.Text = "Hiciste click : " + sum++;

            (sender as Button).Text = "Hiciste Clic!";
        }
    }
}