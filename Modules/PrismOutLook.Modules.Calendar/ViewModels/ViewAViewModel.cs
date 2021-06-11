using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismOutLook.Modules.Calendar.ViewModels
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
