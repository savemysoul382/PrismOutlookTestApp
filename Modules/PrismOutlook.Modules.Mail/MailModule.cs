using System;
using PrismOutlook.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismOutLook.Core;
using PrismOutlook.Modules.Mail.Menus;

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
            this.region_manager.RegisterViewWithRegion(regionName: RegionNames.RibbonRegion, viewType: typeof(HomeTab));
            this.region_manager.RegisterViewWithRegion(regionName: RegionNames.OutlookGroupRegion, viewType: typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry container_registry)
        {
            
        }
    }
}