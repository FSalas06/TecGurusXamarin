﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEjemplo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SingleButtonNavigation : ContentPage
	{
		public SingleButtonNavigation ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculatorPage());
        }
    }
}