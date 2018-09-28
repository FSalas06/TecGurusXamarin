using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TGXFExampleApp.Interfaces
{
    public interface IRestService<T>
    {
        Task<T> GetDataAsync();

        Task SaveDataAsync(T t);

        Task DeleteDataAsync(string id);
    }
}
