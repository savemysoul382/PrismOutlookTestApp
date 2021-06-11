using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismOutLook.Core;

namespace PrismOutlookTestApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager region_manager;
        private String title = "Prism Application";
        public String Title
        {
            get { return this.title; }
            set { SetProperty(storage: ref this.title, value: value); }
        }

        private DelegateCommand<String> navigate_command;
        public DelegateCommand<String> NavigateCommand => this.navigate_command ?? (this.navigate_command = new DelegateCommand<String>(executeMethod: ExecuteNavigationCommand));

        void ExecuteNavigationCommand(String navigation_path)
        {
            if (navigation_path == null) throw new ArgumentNullException(paramName: nameof(navigation_path));
            
            this.region_manager.RequestNavigate(RegionNames.ContentRegion, navigation_path);
        }

        public MainWindowViewModel(IRegionManager region_manager)
        {
            this.region_manager = region_manager;
        }
    }
}
