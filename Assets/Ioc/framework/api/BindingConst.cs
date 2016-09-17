using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.framework.api
{
   public enum BindingConst
    {
        // Null is an acceptable binding,but dictionaries choke on it,so we map null to this instead.
        NULLOID
    }
}
