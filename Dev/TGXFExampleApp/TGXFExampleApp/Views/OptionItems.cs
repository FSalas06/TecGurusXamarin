using System.Collections.Generic;
using System.Collections.ObjectModel;
using TGXFExampleApp.Models;
using TGXFExampleApp.Views.FirstDay;
using System.Linq;
using TGXFExampleApp.Views.SecondDay;

namespace TGXFExampleApp.Views
{
    public static class OptionItems
    {
        public static ObservableCollection<OptionsItemMenu> OptionMenuItems(int day)
        {
            List<OptionsItemMenu> Opt = new List<OptionsItemMenu>
            {
                new OptionsItemMenu
                {
                    TitleOption = "Buttons",
                    TargetType = typeof(ButtonPage),
                    Group = 0
                },

                new OptionsItemMenu
                {
                    TitleOption = "BoxView",
                    TargetType = typeof(BoxViewPage),
                    Group = 0
                },

                new OptionsItemMenu
                {
                    TitleOption = "Picker",
                    TargetType = typeof(PickerPage),
                    Group = 0
                },

                new OptionsItemMenu
                {
                    TitleOption = "Activity Indicator",
                    TargetType = typeof(ActivityIndicatorPagexaml),
                    Group = 1
                },

                new OptionsItemMenu
                {
                    TitleOption = "Progress Bar",
                    TargetType = typeof(ProgressBarPage),
                    Group = 1
                },
               
            };

            ObservableCollection<OptionsItemMenu> Option = 
                new ObservableCollection<OptionsItemMenu>(Opt.Where(o => o.Group == day));
            
            return Option;
        }

        public static Dictionary<string, int> OptionPickerItem()
        {
            Dictionary<string, int> PickerItem = new Dictionary<string, int>
            {
                {"Option 1",1},
                {"Option 2",2},
                {"Option 3",3},
                {"Option 4",4},
            };

            return PickerItem;
        }
    }
}
