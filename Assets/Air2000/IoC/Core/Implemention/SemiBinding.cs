/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: SemiBinding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:04:03
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    public class SemiBinding : ISemiBinding, IManagedList
    {
        protected object[] objectValue;
        public Enum constraint { get; set; }
        public bool uniqueValues { get; set; }
        public SemiBinding()
        {
            constraint = BindingConstraintType.ONE;
            uniqueValues = true;
        }

        #region implemention of IManagedList
        public IManagedList Add(object o)
        {
            if (objectValue == null || (BindingConstraintType)constraint == BindingConstraintType.ONE)
            {
                objectValue = new object[1];
            }
            else
            {
                if (uniqueValues)
                {
                    int aa = objectValue.Length;
                    for (int a = 0; a < aa; a++)
                    {
                        object val = objectValue[a];
                        if (val.Equals(o))
                        {
                            return this;
                        }
                    }
                }

                object[] tempList = objectValue;
                int length = tempList.Length;
                objectValue = new object[length + 1];
                tempList.CopyTo(objectValue, 0);
            }
            objectValue[objectValue.Length - 1] = o;
            return this;
        }
        public IManagedList Add(object[] list)
        {
            if (list != null && list.Length > 0)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Add(list[i]);
                }
            }
            return this;
        }
        public IManagedList Remove(object o)
        {
            if (o.Equals(objectValue) || objectValue == null)
            {
                objectValue = null;
                return this;
            }
            int aa = objectValue.Length;
            for (int a = 0; a < aa; a++)
            {
                object currVal = objectValue[a];
                if (o.Equals(currVal))
                {
                    spliceValueAt(a);
                    return this;
                }
            }
            return this;
        }

        public IManagedList Remove(object[] list)
        {
            foreach (object item in list)
                Remove(item);

            return this;
        }

        public virtual object value
        {
            get
            {
                if (constraint.Equals(BindingConstraintType.ONE))
                {
                    return (objectValue == null) ? null : objectValue[0];
                }
                return objectValue;
            }
        }
        #endregion

        /// <summary>
        /// CN: 移除指定索引位置的元素.
        /// <para></para>
        /// EN: Remove the value at index splicePos.
        /// </summary>
        /// <param name="splicePos"></param>
        protected void spliceValueAt(int splicePos)
        {
            object[] newList = new object[objectValue.Length - 1];
            int mod = 0;
            int aa = objectValue.Length;
            for (int a = 0; a < aa; a++)
            {
                if (a == splicePos)
                {
                    mod = -1;
                    continue;
                }
                newList[a + mod] = objectValue[a];
            }
            objectValue = (newList.Length == 0) ? null : newList;
        }
    }
}
