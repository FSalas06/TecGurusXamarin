using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.SecondDay
{
    class StepperViewModel : BaseViewModel
    {
        private int _stepperValue;
        private string _showValue;

        public int StepperValue
        {
            get
            {
                return _stepperValue;
            }
            set
            {
                SetObservableProperty(ref _stepperValue, value);
                if(ValueUpdate.CanExecute(_stepperValue))
                {
                    ValueUpdate.Execute(_stepperValue);
                }
            }
        }

        public string ShowValue
        {
            get
            {
                return _showValue;
            }
            set
            {
                SetObservableProperty(ref _showValue, value);
            }
        }

        public ICommand ValueUpdate { get; private set; }

        public StepperViewModel()
        {
            ValueUpdate = new Command<int>(OnValueUpdate);
        }

        private void OnValueUpdate(int val)
        {
            ShowValue = val.ToString();
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            ShowValue = StepperValue.ToString();
        }
    }
}
