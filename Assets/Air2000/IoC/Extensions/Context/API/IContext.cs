/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IContext.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 10:55:29
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Air2000.IoC.Core;

namespace Air2000.IoC.Extensions.Context
{
    public interface IContext
    {
        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Kicks off the internal Context binding/instantiation mechanisms.
        /// </summary>
        /// <returns></returns>
        IContext Start();

        /// <summary>
        /// CN:
        /// <para></para>
        /// EN: Fires ContextEvent.Start to launch the application.
        /// </summary>
        void Launch();

        IContext RegisterContext(IContext context);

        IContext UnregisterContext(IContext context);
    }
}
