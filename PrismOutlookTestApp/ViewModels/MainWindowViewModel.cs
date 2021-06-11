using System;
using Prism.Mvvm;

namespace PrismOutlookTestApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private String title = "Prism Application";
        public String Title
        {
            get { return this.title; }
            set { SetProperty(storage: ref this.title, value: value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
