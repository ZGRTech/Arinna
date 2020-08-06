using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.DDD.Domain
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoreMemberAttribute : Attribute
    {
    }
}
