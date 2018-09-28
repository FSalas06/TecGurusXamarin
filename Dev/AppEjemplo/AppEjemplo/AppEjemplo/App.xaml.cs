using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace AppEjemplo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new SingleButtonNavigation());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            Debug.WriteLine("OnStar");
		}

		protected override void OnSleep ()
		{
            // Handle when your app sleeps
            Debug.WriteLine("OnSleep");
        }

		protected override void OnResume ()
		{
            // Handle when your app resumes
            Debug.WriteLine("OnREsume");
        }
	}
}
