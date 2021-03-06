using System;
using PrismOutlook.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using PrismOutLook.Core;
using PrismOutlook.Modules.Mail.Menus;
using PrismOutlook.Modules.Mail.ViewModels;

namespace PrismOutlook.Modules.Mail
{
    public class MailModule : IModule
    {
        private readonly IRegionManager region_manager;

        public MailModule(IRegionManager region_manager)
        {
            this.region_manager = region_manager;
        }

        public void OnInitialized(IContainerProvider container_provider)
        {
            this.region_manager.RegisterViewWithRegion(regionName: RegionNames.OutlookGroupRegion, viewType: typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry container_registry)
        {
            ViewModelLocationProvider.Register<MailGroup, MailGroupViewModel>();
            container_registry.RegisterForNavigation<MailList, MailListViewModel>();
        }
    }
}