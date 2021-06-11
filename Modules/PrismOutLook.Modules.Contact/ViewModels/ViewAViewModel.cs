using Prism.Mvvm;
using System;

namespace PrismOutLook.Modules.Contact.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private String message;
        public String Message
        {
            get { return this.message; }
            set { SetProperty(storage: ref this.message, value: value); }
        }

        public ViewAViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
