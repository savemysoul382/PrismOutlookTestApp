using Prism.Mvvm;
using PrismOutlook.Business;
using System.Collections.ObjectModel;
using Prism.Commands;
using PrismOutLook.Core;

namespace PrismOutlook.Modules.Mail.ViewModels
{
    public class MailGroupViewModel : ViewModelBase
    {
        private readonly IApplicationCommands application_commands;
        public ObservableCollection<NavigationItem> Items { get; set; }

        private DelegateCommand<NavigationItem> selected_command;
        public DelegateCommand<NavigationItem> SelectedCommand => this.selected_command ?? (this.selected_command = new DelegateCommand<NavigationItem>(ExecuteSelectedCommand));

        public MailGroupViewModel(IApplicationCommands application_commands)
        {
            this.application_commands = application_commands;
            GenerateMenu();
        }

        void ExecuteSelectedCommand(NavigationItem navigation_item)
        {
            if (navigation_item != null) this.application_commands.NavigateCommand.Execute(navigation_item.NavigationPath);
        }

        void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            var root = new NavigationItem() {Caption = "Personal Folder", NavigationPath = "MailList?id=Default"};
            root.Items.Add(new NavigationItem() {Caption = "Inbox", NavigationPath = "MailList?id=inbox" });
            root.Items.Add(new NavigationItem() {Caption = "Deleted", NavigationPath = "MailList?id=Delete" });
            root.Items.Add(new NavigationItem() {Caption = "Sent", NavigationPath = "MailList?id=Sent" });

            Items.Add(root);
        }
    }
}