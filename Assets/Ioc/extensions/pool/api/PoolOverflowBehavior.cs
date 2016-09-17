using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.pool.api
{
    public enum PoolOverflowBehavior
    {
        EXCEPTION,

        WARNING,

        IGNORE,
    }
}
