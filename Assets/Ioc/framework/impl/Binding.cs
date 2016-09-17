﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Ioc.framework.api;

namespace Assets.Ioc.framework.impl
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

        #region IBinding implementation
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

        virtual public IBinding Bind<T>()
        {
            return Bind(typeof(T));
        }

        virtual public IBinding Bind(object o)
        {
            _key.Add(o);
            return this;
        }

        virtual public IBinding To<T>()
        {
            return To(typeof(T));
        }

        virtual public IBinding To(object o)
        {
            _value.Add(o);
            if (resolver != null)
                resolver(this);
            return this;
        }

        virtual public IBinding ToName<T>()
        {
            return ToName(typeof(T));
        }

        virtual public IBinding ToName(object o)
        {
            object toName = (o == null) ? BindingConst.NULLOID : o;
            _name.Add(toName);
            if (resolver != null)
                resolver(this);
            return this;
        }

        virtual public IBinding Named<T>()
        {
            return Named(typeof(T));
        }

        virtual public IBinding Named(object o)
        {
            return _name.value == o ? this : null;
        }

        virtual public void RemoveKey(object o)
        {
            _key.Remove(o);
        }

        virtual public void RemoveValue(object o)
        {
            _value.Remove(o);
        }

        virtual public void RemoveName(object o)
        {
            _name.Remove(o);
        }

        virtual public IBinding Weak()
        {
            _isWeak = true;
            return this;
        }
        #endregion

    }
}
