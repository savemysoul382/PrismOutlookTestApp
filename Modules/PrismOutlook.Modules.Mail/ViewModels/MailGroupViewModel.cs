using Prism.Mvvm;
using PrismOutlook.Business;
using System.Collections.ObjectModel;

namespace PrismOutlook.Modules.Mail.ViewModels
{
    public class MailGroupViewModel : BindableBase
    {
        public ObservableCollection<NavigationItem> Items { get; set; }

        public MailGroupViewModel()
        {
            GenerateMenu();
        }

        void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            var root = new NavigationItem() {Caption = "Personal Folder", NavigationPath = "MailList"};
            root.Items.Add(new NavigationItem() {Caption = "Inbox", NavigationPath = ""});
            root.Items.Add(new NavigationItem() {Caption = "Deleted", NavigationPath = ""});
            root.Items.Add(new NavigationItem() {Caption = "Sent", NavigationPath = ""});

            Items.Add(root);
        }
    }
}