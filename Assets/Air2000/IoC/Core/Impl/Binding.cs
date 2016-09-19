/*----------------------------------------------------------------
            // Copyright © 2014-2016 Air2000
            // 
            // FileName: Binding.cs
			// Describle:
			// Created By:  Wells Hsu
			// Date&Time:  2016/9/14 11:04:47
            // Modify History:
            //
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air2000.IoC.Core
{
    public class Binding : IBinding
    {
        public Binder.BindingResolver resolver;

        protected ISemiBinding _key;
        protected ISemiBinding _value;
        protected ISemiBinding _name;

        public Binding(Binder.BindingResolver resolver)
        {
            this.resolver = resolver;

            _key = new SemiBinding();
            _value = new SemiBinding();
            _name = new SemiBinding();

            keyConstraint = BindingConstraintType.ONE;
            nameConstraint = BindingConstraintType.ONE;
            valueConstraint = BindingConstraintType.MANY;
        }

        public Binding() : this(null) { }

        #region implemention of IBinding

        public object key
        {
            get
            {
                return _key.value;
            }
        }
        public object value
        {
            get
            {
                return _value.value;
            }
        }
        public object name
        {
            get
            {
                return (_name.value == null) ? BindingConst.NULLOID : _name.value;
            }
        }
        public Enum keyConstraint
        {
            get
            {
                return _key.constraint;
            }
            set
            {
                _key.constraint = value;
            }
        }
        public Enum valueConstraint
        {
            get
            {
                return _value.constraint;
            }
            set
            {
                _value.constraint = value;
            }
        }
        public Enum nameConstraint
        {
            get
            {
                return _name.constraint;
            }
            set
            {
                _name.constraint = value;
            }
        }
        protected bool _isWeak = false;
        public bool isWeak
        {
            get
            {
                return _isWeak;
            }
        }
        public virtual IBinding Bind<T>()
        {
            return Bind(typeof(T));
        }
        public virtual IBinding Bind(object o)
        {
            _key.Add(o);
            return this;
        }
        public virtual IBinding To<T>()
        {
            return To(typeof(T));
        }
        public virtual IBinding To(object o)
        {
            _value.Add(o);
            if (resolver != null)
                resolver(this);
            return this;
        }
        public virtual IBinding ToName<T>()
        {
            return ToName(typeof(T));
        }
        public virtual IBinding ToName(object o)
        {
            object toName = (o == null) ? BindingConst.NULLOID : o;
            _name.Add(toName);
            if (resolver != null)
                resolver(this);
            return this;
        }
        public virtual IBinding Named<T>()
        {
            return Named(typeof(T));
        }
        public virtual IBinding Named(object o)
        {
            return _name.value == o ? this : null;
        }
        public virtual void RemoveKey(object o)
        {
            _key.Remove(o);
        }
        public virtual void RemoveValue(object o)
        {
            _value.Remove(o);
        }
        public virtual void RemoveName(object o)
        {
            _name.Remove(o);
        }
        public virtual IBinding Weak()
        {
            _isWeak = true;
            return this;
        }

        #endregion

    }
}
