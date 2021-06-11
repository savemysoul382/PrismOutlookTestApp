using Infragistics.Windows.Ribbon;
using Prism.Regions;
using System;
using System.Collections.Specialized;

namespace PrismOutlookTestApp.Core.Regions
{
    public class XamRibbonRegionAdapter : RegionAdapterBase<XamRibbon>
    {
        public XamRibbonRegionAdapter(IRegionBehaviorFactory region_behavior_factory)
            : base(regionBehaviorFactory: region_behavior_factory)
        {
        }

        protected override void Adapt(IRegion region, XamRibbon region_target)
        {
            if (region == null) throw new ArgumentNullException(paramName: nameof(region));
            if (region_target == null) throw new ArgumentNullException(paramName: nameof(region_target));

            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (var view in e.NewItems)
                    {
                        AddViewToRegion(view: view, xam_ribbon: region_target);
                    }

                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (var view in e.OldItems)
                    {
                        RemoveViewFromRegion(view: view, xam_ribbon: region_target);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }

        static void AddViewToRegion(object view, XamRibbon xam_ribbon)
        {
            if (view is RibbonTabItem ribbon_tab_item)
            {
                xam_ribbon.Tabs.Add(item: ribbon_tab_item);
            }
        }

        static void RemoveViewFromRegion(object view, XamRibbon xam_ribbon)
        {
            if (view is RibbonTabItem ribbon_tab_item)
            {
                xam_ribbon.Tabs.Remove(item: ribbon_tab_item);
            }
        }
    }
}
