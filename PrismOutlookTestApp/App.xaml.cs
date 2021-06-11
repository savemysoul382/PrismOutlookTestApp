using PrismOutlookTestApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Infragistics.Windows.OutlookBar;
using Infragistics.Windows.Ribbon;
using Prism.Regions;
using PrismOutLook.Modules.Contact;
using PrismOutlook.Modules.Mail;
using PrismOutlookTestApp.Core.Regions;

namespace PrismOutlookTestApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial  class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry container_registry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog module_catalog)
        {
            module_catalog.AddModule<MailModule>();
            module_catalog.AddModule<ContactsModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings region_adapter_mappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings: region_adapter_mappings);
            region_adapter_mappings.RegisterMapping(controlType: typeof(XamOutlookBar), adapter: Container.Resolve<XamOutlookBarRegionAdapter>());
            region_adapter_mappings.RegisterMapping(controlType: typeof(XamRibbon), adapter: Container.Resolve<XamRibbonRegionAdapter>());
        }
    }
}
