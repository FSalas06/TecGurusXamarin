using System.Collections.Generic;
using System.Threading.Tasks;

namespace TGXFExampleApp.Interfaces
{
    public interface IServicesDataBase<T> where T : class
    {
        Task<List<T>> GetTableAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddToTableAsync(T data);
        Task<T> UpdateTable(T data);
        Task<bool> DeleteById(int data);
    }
}
