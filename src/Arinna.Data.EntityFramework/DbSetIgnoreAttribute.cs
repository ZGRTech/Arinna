using System;
using System.Collections.Generic;
using System.Text;

namespace Arinna.Data.EntityFramework
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class DbSetIgnoreAttribute : Attribute
    {

    }
}
