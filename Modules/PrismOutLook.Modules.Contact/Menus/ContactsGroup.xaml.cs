using System;
using Infragistics.Windows.OutlookBar;
using PrismOutlookTestApp;

namespace PrismOutLook.Modules.Contact.Menus
{
    /// <summary>
    /// Логика взаимодействия для ContactsGroup.xaml
    /// </summary>
    public partial class ContactsGroup : OutlookBarGroup, IOutlookBarGroup
    {
        private String default_navigation_path;

        public ContactsGroup()
        {
            InitializeComponent();
        }

        public String DefaultNavigationPath => "ViewA";
    }
}
