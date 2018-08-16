using System;
using System.IO;
using TGXFExampleApp.Droid.DependencyServices;
using TGXFExampleApp.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseAndroid))]
namespace TGXFExampleApp.Droid.DependencyServices
{
    public class DataBaseAndroid : IDataBase
    {
        public string GetDatabasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, Constants.NameDataBase);
        }
    }
}
