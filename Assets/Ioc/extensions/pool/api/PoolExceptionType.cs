using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Ioc.extensions.pool.api
{
    public enum PoolExceptionType
    {
        OVERFLOW,

        TYPE_MISMATCH,

        NO_INSTANCE_PROVIDER,
    }
}
