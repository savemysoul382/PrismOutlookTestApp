using System.Windows.Controls;
using PrismOutLook.Core;
using PrismOutLook.Modules.Contact.Menus;

namespace PrismOutLook.Modules.Contact.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    [DependentView(RegionNames.RibbonRegion, typeof(HomeTab))]

    public partial class ViewA : UserControl
    {
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
