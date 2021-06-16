using Prism.Mvvm;
using Prism.Regions;
using System;

namespace PrismOutLook.Core
{
    public class ViewModelBase : BindableBase, IConfirmNavigationRequest
    {
        public virtual void OnNavigatedTo(NavigationContext navigation_context)
        {
        }

        public virtual Boolean IsNavigationTarget(NavigationContext navigation_context)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigation_context)
        {
        }

        public virtual void ConfirmNavigationRequest(NavigationContext navigation_context, Action<Boolean> continuation_callback)
        {
            continuation_callback(true);
        }
    }
}
