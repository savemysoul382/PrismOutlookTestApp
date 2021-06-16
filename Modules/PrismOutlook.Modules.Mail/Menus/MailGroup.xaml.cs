using System;
using Infragistics.Controls.Menus;
using Infragistics.Windows.OutlookBar;
using PrismOutlook.Business;
using PrismOutlookTestApp;

namespace PrismOutlook.Modules.Mail.Menus
{
    /// <summary>
    /// Логика взаимодействия для MailGroup.xaml
    /// </summary>
    public partial class MailGroup : OutlookBarGroup, IOutlookBarGroup
    {

        public MailGroup()
        {
            InitializeComponent();
        }

        public String DefaultNavigationPath
        {
            get
            {
                var item = this.DataTree.SelectedDataItems?[0] as NavigationItem;
                return item != null ? item.NavigationPath : "MailList";
            }
        }
    }
}
