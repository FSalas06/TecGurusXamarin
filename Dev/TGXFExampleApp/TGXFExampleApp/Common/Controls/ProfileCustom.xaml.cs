using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TGXFExampleApp.Common.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileCustom : ContentView
	{
		public ProfileCustom ()
		{
			InitializeComponent ();
		}
       
        public string UsernameText { get; set; }
        public static readonly BindableProperty UsernameTextProperty = 
            BindableProperty.Create(            
                nameof(UsernameText),
                typeof(string),    
                typeof(ProfileCustom),                        
                string.Empty,  
                BindingMode.TwoWay,
                propertyChanged: UsernameTextPropertyChanged);

        public string CompanyText { get; set; }
        public static readonly BindableProperty CompanyTextProperty =
            BindableProperty.Create(
                nameof(CompanyText),
                typeof(string),
                typeof(ProfileCustom),
                string.Empty,
                BindingMode.TwoWay,
                propertyChanged: CompanyTextPropertyChanged);
        
        private static void UsernameTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ProfileCustom)bindable;
            control.lb_username.Text = newValue.ToString();
        }

        private static void CompanyTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ProfileCustom)bindable;
            control.lb_company.Text = newValue.ToString();
        }
    }
}