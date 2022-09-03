using System;
using System.ComponentModel;

namespace RxjhTool
{
    public class CustomPropertyDescriptor : PropertyDescriptor
    {
        private global::RxjhTool.CustomProperty eval_a;

        public CustomPropertyDescriptor(global::RxjhTool.CustomProperty customProperty, Attribute[] attrs) : base(customProperty.Name, attrs)
        {
            this.eval_a = customProperty;
        }

        public override bool CanResetValue(object component)
        {
            return (this.eval_a.DefaultValue != null);
        }

        public override object GetValue(object component)
        {
            return this.eval_a.Value;
        }

        public override void ResetValue(object component)
        {
            this.eval_a.ResetValue();
        }

        public override void SetValue(object component, object value)
        {
            this.eval_a.Value = value;
        }

        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }

        public override string Category
        {
            get
            {
                return this.eval_a.Category;
            }
        }

        public override Type ComponentType
        {
            get
            {
                return this.eval_a.GetType();
            }
        }

        public object CustomProperty
        {
            get
            {
                return this.eval_a;
            }
        }

        public override string Description
        {
            get
            {
                return this.eval_a.Description;
            }
        }

        public override string DisplayName
        {
            get
            {
                return this.eval_a.Name;
            }
        }

        public override bool IsBrowsable
        {
            get
            {
                return this.eval_a.IsBrowsable;
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                return this.eval_a.IsReadOnly;
            }
        }

        public override Type PropertyType
        {
            get
            {
                return this.eval_a.ValueType;
            }
        }
    }
}

