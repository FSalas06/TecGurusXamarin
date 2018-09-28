using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEjemplo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
		public CalculatorPage (string val)
		{
			InitializeComponent ();
            PanelCalculator.Text = val;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            PanelCalculator.Text += (sender as Button).Text;
        }
    }
}