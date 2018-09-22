using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using TGXFExampleApp.Helpers;
using TGXFExampleApp.Models;
using TGXFExampleApp.Services;
using TGXFExampleApp.ViewModels.Shared;

namespace TGXFExampleApp.ViewModels.ExampleApp.RestServices
{
	public class AmiiboViewModel : BaseViewModel
    {
        private ObservableCollection<Character> _characters;
        private CharacterService _service;

        public ObservableCollection<Character> Characters
        {
            get
            {
                return _characters;
            }
            set
            {
                SetObservableProperty(ref _characters, value);
            }
        }

        public AmiiboViewModel()
        {
            _service = new CharacterService();
        }

        public async override void OnAppearing()
        {
            base.OnAppearing();
            await LoadCharacters();
        }

        public async Task LoadCharacters()
        {
            try
            {
                //var url = "http://www.amiiboapi.com/api/character";
                //var service = new HttpHelper<Characters>();
                //var characters = await service.GetDataAsync(url);
                //Characters = new ObservableCollection<Character>(characters.amiibo);
                IsBusy = true;
                //await Task.Delay(5000);
                var character = await _service.GetAllAmiibosList();
                Characters = new ObservableCollection<Character>(character.amiibo);
                IsBusy = false;
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"LoadCharacters - ex : {ex.Message}");
            }
        }
    }
}
