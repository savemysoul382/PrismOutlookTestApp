using System;

namespace PrismOutLook.Core
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class DependentViewAttribute : Attribute
    {
        public String Region { get; set; }

        public Type Type { get; set; }

        public DependentViewAttribute(String region,  Type type)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Region = region ?? throw new ArgumentNullException(nameof(region));
        }
    }
}
