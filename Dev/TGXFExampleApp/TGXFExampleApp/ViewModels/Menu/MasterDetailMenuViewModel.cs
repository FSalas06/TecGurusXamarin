using TGXFExampleApp.ViewModels.Shared;

namespace TGXFExampleApp.ViewModels.Menu
{
    public class MasterDetailMenuViewModel : BaseViewModel
    {
        private string _companyProp;
        private string _usernameProp;

        public string CompanyProp
        {
            get { return _companyProp; }
            set { SetObservableProperty(ref _companyProp, value); }
        }

        public string UsernameProp
        {
            get { return _usernameProp; }
            set { SetObservableProperty(ref _usernameProp, value); }
        }

        public MasterDetailMenuViewModel()
        {
            UsernameProp = "FSALAS";
            CompanyProp = "Company123";
        }

        
    }
}
