using PrismOutlook.Modules.Mail.Menus;
using PrismOutLook.Core;
using System.Windows.Controls;

namespace PrismOutlook.Modules.Mail.Views
{
    /// <summary>
    /// Interaction logic for MailList
    /// </summary>
    [DependentView(region: RegionNames.RibbonRegion, type: typeof(HomeTab))]
    public partial class MailList : UserControl
    {
        public MailList()
        {
            InitializeComponent();
        }
    }
}
