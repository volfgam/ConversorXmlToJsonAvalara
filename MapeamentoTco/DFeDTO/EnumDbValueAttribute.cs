using System;

namespace TCO.WebApi.Abstractions.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class EnumDbValueAttribute : Attribute
    {
        public string DbValue { get; set; }

        public EnumDbValueAttribute(string dbValue) => DbValue = dbValue;
    }
}