using Prism.Commands;
using Prism.Regions;
using PrismOutLook.Core;
using System;

namespace PrismOutlookTestApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
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

        public MainWindowViewModel(IRegionManager region_manager, IApplicationCommands application_commands)
        {
            this.region_manager = region_manager;
            application_commands.NavigateCommand.RegisterCommand(command: NavigateCommand);
        }

        void ExecuteNavigationCommand(String navigation_path)
        {
            if (navigation_path == null) throw new ArgumentNullException(paramName: nameof(navigation_path));

            this.region_manager.RequestNavigate(regionName: RegionNames.ContentRegion, source: navigation_path);
        }
    }
}
