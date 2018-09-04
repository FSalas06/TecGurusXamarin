using System;
using System.Collections.ObjectModel;

namespace TGXFExampleApp.ViewModels.Menu
{
    public class Cover
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }

    public class MasterDetailMenuViewModel
    {
        public ObservableCollection<Cover> Covers { get; set; }

        public MasterDetailMenuViewModel()
        {
            Covers = new ObservableCollection<Cover>
            {
                new Cover
                {
                    ImageUrl = "devxam.png",
                    Name = "Dev"
                },
                 new Cover
                {
                    ImageUrl = "code.png",
                    Name = "Consulting"
                 },
                new Cover
                {
                    ImageUrl = "binary.png",
                    Name = "Teaching"
                }
            };
        }
    }
}
