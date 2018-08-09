using System;
using System.Windows.Input;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.SecondDay
{
    public class ProgressBarViewModel : BaseViewModel
    {
        private double _bar1Prog;
        private double _bar2Prog;
        private string _progress2Text;

        public string Progress2Text
        {
            get
            {
                return _progress2Text;
            }
            set
            {
                SetObservableProperty(ref _progress2Text, value);
            }
        }

        public double Bar2Prog
        {
            get
            {
                return _bar2Prog;
            }
            set
            {
                SetObservableProperty(ref _bar2Prog, value);
            }
        }
        public double Bar1Prog
        {
            get
            {
                return _bar1Prog;
            }
            set
            {
                SetObservableProperty(ref _bar1Prog, value);
            }
        }

        public ICommand ProgressCommand { get; private set; }

        public ProgressBarViewModel()
        {
            ProgressCommand = new Command(OnProgress);
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            LoadProgressBarPage();
        }

        private void OnProgress()
        {
            if (Bar1Prog == 1)
            {
                Bar1Prog = 0;

            }
            else
            {
                Bar1Prog += .2;

            }
        }

        private void LoadProgressBarPage()
        {
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
            
                Bar2Prog += .2;
                Progress2Text = "Your progress : " + Bar2Prog;
                if (Bar2Prog >= 1)
                {
                    Progress2Text = "Complete";
                    return false;
                }


                return true; // True = Repeat again, False = Stop the timer
            });
        }
    }
}
