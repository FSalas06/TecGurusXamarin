using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TGXFExampleApp.Models;

namespace TGXFExampleApp.Services
{
    public class CharacterService : BaseService
    {
        public CharacterService() : base("character"){}

        public async Task<Characters> GetAllAmiibosList()
        {
            var result = await GetAsync<Characters>("");
            return result;
        }
    }
}
