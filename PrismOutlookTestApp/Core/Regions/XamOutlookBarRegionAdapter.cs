using Infragistics.Windows.OutlookBar;
using Prism.Regions;
using System.Collections.Specialized;

namespace PrismOutlookTestApp.Core.Regions
{
    public class XamOutlookBarRegionAdapter : RegionAdapterBase<XamOutlookBar>
    {
        public XamOutlookBarRegionAdapter(IRegionBehaviorFactory region_behavior_factory) : base(regionBehaviorFactory: region_behavior_factory)
        {
        }

        protected override void Adapt(IRegion region, XamOutlookBar region_target)
        {
            region.Views.CollectionChanged += ((x, y) =>
            {
                switch (y.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        {
                            foreach (OutlookBarGroup group in y.NewItems)
                            {
                                region_target.Groups.Add(item: group);

                                //The WPF XamOutlookBar does not automatically select the first group in it's collection.
                                //So we must manually select the group if it is the first one in the collection, but we don't
                                //want to excute this code every time a new group is added, only if the first group is the current group being added.
                                if (region_target.Groups[index: 0] == group)
                                {
                                    region_target.SelectedGroup = group;
                                }
                            }

                            break;
                        }
                    case NotifyCollectionChangedAction.Remove:
                        {
                            foreach (OutlookBarGroup group in y.OldItems)
                            {
                                region_target.Groups.Remove(item: group);
                            }

                            break;
                        }
                }
            });
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}