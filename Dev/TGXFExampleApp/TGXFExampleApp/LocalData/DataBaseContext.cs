using Microsoft.EntityFrameworkCore;
using TGXFExampleApp.Interfaces;
using TGXFExampleApp.Models;
using Xamarin.Forms;

namespace TGXFExampleApp.LocalData
{
    public class DataBaseContext : DbContext
    {
        public DbSet<SupermarketItems> MySuperMarketList { get; set; }

        readonly string pathDB;

        public DataBaseContext(string pathDB)
        {
            this.pathDB = pathDB;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IDataBase>().GetDatabasePath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
