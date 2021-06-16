using Infragistics.Themes;
using Infragistics.Windows.OutlookBar;
using Infragistics.Windows.Ribbon;
using Prism.Regions;
using PrismOutLook.Core;
using System;
using System.Windows;

namespace PrismOutlookTestApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : XamRibbonWindow
    {
        private readonly IApplicationCommands application_commands;

        public MainWindow(IApplicationCommands application_commands
        )
        {
            this.application_commands = application_commands;
            InitializeComponent();

            ThemeManager.ApplicationTheme = new Office2013Theme();
        }

        private void XamOutlookBar_OnSelectedGroupChanged(Object sender, RoutedEventArgs e)
        {
            if (((XamOutlookBar)sender).SelectedGroup is IOutlookBarGroup @group)
            {
                //TODO navigate
                //group.DefaultNavigationPath;
                this.application_commands.NavigateCommand.Execute(group.DefaultNavigationPath);
            }
        }
    }
}
