using System;
using System.IO;
using TGXFExampleApp.Interfaces;
using TGXFExampleApp.iOS.DependencyServices;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseIOS))]
namespace TGXFExampleApp.iOS.DependencyServices
{
    public class DataBaseIOS : IDataBase
    {
        public string GetDatabasePath()
        {
            return Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "..", "Library", Constants.NameDataBase);
        }
    }
}
