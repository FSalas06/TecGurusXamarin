using System;
using System.Collections.ObjectModel;
using TGXFExampleApp.Models;
using TGXFExampleApp.Views.FirstDay;

namespace TGXFExampleApp.Views
{
    public class OptionItems
    {
        public ObservableCollection<OptionsItemMenu> Option
        {
            get;
            set;
        }

        public OptionItems()
        {
            Option = new ObservableCollection<OptionsItemMenu>
            {
                //
                new OptionsItemMenu
                {
                    TitleOption = "Styles",
                    TargetType = typeof(BoxViewPage),
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
                    TitleOption = "label",
                    TargetType = typeof(BoxViewPage),
                    Group = 0
                },

				new OptionsItemMenu
                {
                    TitleOption = "label",
                    TargetType = typeof(BoxViewPage),
                    Group = 1
                },

				new OptionsItemMenu
                {
                    TitleOption = "label",
                    TargetType = typeof(BoxViewPage),
                    Group = 1
                }
            };
        }
    }
}
