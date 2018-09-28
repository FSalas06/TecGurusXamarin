using System;
using System.Windows.Input;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.ExampleApp
{
    public class CalculatorViewModel : BaseViewModel
    {
        private string _panelCalc;
        private string _value1;
        private string _value2;

        public string PanelCalc
        {
            get
            {
                return _panelCalc;
            }
            set
            {
                SetObservableProperty(ref _panelCalc, value);
            }
        }

        public string Value1
        {
            get
            {
                return _value1;
            }
            set
            {
                SetObservableProperty(ref _value1, value);
            }
        }

        public string Value2
        {
            get
            {
                return _value2;
            }
            set
            {
                SetObservableProperty(ref _value2, value);
            }
        }

        public ICommand PressButtonCalc { private set; get; }
        public ICommand PressButtonCalcPL { private set; get; }
        public ICommand PressButtonCalcLS { private set; get; }
        public ICommand PressButtonCalcEQ { private set; get; }


        public CalculatorViewModel()
        {
            PressButtonCalc = new Command<string>(OnPressButtonCalc);
            PressButtonCalcPL = new Command(OnPressButtonCalcPL);
            PressButtonCalcLS = new Command(OnPressButtonCalcLS);
            PressButtonCalcEQ = new Command(OnPressButtonCalcEQ);
        }

        private void OnPressButtonCalcEQ(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnPressButtonCalcLS(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnPressButtonCalcPL(object obj)
        {
            if (Value1 == null)
            {
                Value1 = PanelCalc;
                PanelCalc = string.Empty;
            }
            else
            {
                Value2 = (Convert.ToDecimal(Value1) + Convert.ToDecimal(PanelCalc)).ToString();
                PanelCalc = Value2;
                Value1 = null;
            }
        }

        private void OnPressButtonCalc(string number)
        {
            PanelCalc += number;
        }
    }
}
