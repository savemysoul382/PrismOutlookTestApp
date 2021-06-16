using Prism.Regions;
using PrismOutLook.Core;
using System;

namespace PrismOutlook.Modules.Mail.ViewModels
{
    public class MailListViewModel : ViewModelBase, INavigationAware
    {
        private string title = "Default";

        public string Title
        {
            get { return this.title; }
            set { SetProperty(ref this.title, value); }
        }

        public MailListViewModel()
        {
        }

        public override void OnNavigatedTo(NavigationContext navigation_context)
        {
            Title = navigation_context.Parameters.GetValue<String>("id");
        }
    }
}