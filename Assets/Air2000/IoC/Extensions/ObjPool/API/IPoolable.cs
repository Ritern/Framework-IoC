/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IPoolable.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 14:05:23
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.ObjPool
{
    public interface IPoolable
    {
        void Restore();

        void Retain();

        void Release();

        bool retain { get; }
    }
}
