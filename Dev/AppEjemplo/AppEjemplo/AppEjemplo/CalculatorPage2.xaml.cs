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
	public partial class CalculatorPage2 : ContentPage
	{
        string Value1;
        string Value2;

        public CalculatorPage2 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var num = (sender as Button).Text;
            panelCalc.Text += num;
        }

        private void ButtonPlus_Clic(object sender, EventArgs e)
        {
            if (Value1 == null)
            {
                Value1 = panelCalc.Text;
                panelCalc.Text = string.Empty;
            }
            else
            {
                Value2 = (Convert.ToDecimal(Value1) + Convert.ToDecimal(panelCalc.Text)).ToString();
                panelCalc.Text = Value2;
                Value1 = null;
            }
        }
    }
}