/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: IThemeContext.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/18 11:00:56
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Extensions.Context
{
    public interface IThemeContext : IContext
    {
        void RegisterView(object view);
        void UnregisterView(object view);
        object GetContextView();
    }
}
