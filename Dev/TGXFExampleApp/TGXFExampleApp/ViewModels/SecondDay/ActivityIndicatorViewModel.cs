using System.Windows.Input;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.SecondDay
{
    public class ActivityIndicatorViewModel : BaseViewModel
    {
        private bool _runActInd;
        private bool _visibleActInd;

        public bool RunActInd
        {
            get
            {
                return _runActInd;
            }
            set
            {
                SetObservableProperty(ref _runActInd, value);
            }
        }
        public bool VisibleActInd
        {
            get
            {
                return _visibleActInd;
            }
            set
            {
                //SetObservableProperty(ref _visibleActInd, value);
                _visibleActInd = value;
                OnPropertyChanged();
            }
        }

        public ICommand RunningCommand { get; private set; }
        public ICommand VisibleCommand { get; private set; }

        public ActivityIndicatorViewModel()
        {
            RunningCommand = new Command(OnRunning);
            VisibleCommand = new Command(OnVisible);
            VisibleActInd = false;
            RunActInd = false;
        }

        private void OnVisible()
        {
            VisibleActInd = !VisibleActInd;
        }

        private void OnRunning()
        {
            RunActInd = !RunActInd;
        }
    }
}
