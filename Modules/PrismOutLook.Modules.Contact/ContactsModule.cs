using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismOutLook.Core;
using PrismOutLook.Modules.Contact.Menus;

namespace PrismOutLook.Modules.Contact
{
    public class ContactsModule : IModule
    {
        private readonly IRegionManager region_manager;

        public ContactsModule(IRegionManager region_manager)
        {
            this.region_manager = region_manager;
        }
        public void OnInitialized(IContainerProvider container_provider)
        {
            this.region_manager.RegisterViewWithRegion(regionName: RegionNames.OutlookGroupRegion, viewType: typeof(ContactsGroup));
        }

        public void RegisterTypes(IContainerRegistry container_registry)
        {
            
        }
    }
}