using System.IO;
using System.Threading.Tasks;

namespace TGXFExampleApp.Interfaces
{
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();
    }
}
