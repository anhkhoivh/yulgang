namespace RxjhTool
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public class CustomProperty
    {
        private string a;
        private object d;
        private object eval_b;
        private object eval_c;
        private PropertyInfo[] eval_e;
        [CompilerGenerated]
        private string[] eval_f;
        [CompilerGenerated]
        private Type eval_g;
        [CompilerGenerated]
        private bool eval_h;
        [CompilerGenerated]
        private string eval_i;
        [CompilerGenerated]
        private string eval_j;
        [CompilerGenerated]
        private bool eval_k;
        [CompilerGenerated]
        private Type eval_l;
        [CompilerGenerated]
        private bool eval_m;

        public CustomProperty()
        {
            this.a = string.Empty;
        }

        public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象) : this(name, new string[] { 属性名 }, null, null, null, isReadOnly, true, category, description, 对象, null, false)
        {
        }

        public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, bool converterType) : this(name, new string[] { 属性名 }, null, null, null, isReadOnly, true, category, description, 对象, null, converterType)
        {
        }

        public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, Type editorType) : this(name, new string[] { 属性名 }, null, null, null, isReadOnly, true, category, description, 对象, editorType, false)
        {
        }

        public CustomProperty(string name, string 属性名, bool isReadOnly, string category, string description, object 对象, Type editorType, bool converterType) : this(name, new string[] { 属性名 }, null, null, null, isReadOnly, true, category, description, 对象, editorType, converterType)
        {
        }

        public CustomProperty(string name, string[] 属性名, Type valueType, object defaultValue, object value, bool isReadOnly, bool isBrowsable, string category, string description, object 对象, Type editorType, bool converterType)
        {
            this.a = string.Empty;
            this.Name = name;
            this.PropertyNames = 属性名;
            this.ValueType = valueType;
            this.eval_b = defaultValue;
            this.eval_c = value;
            this.IsReadOnly = isReadOnly;
            this.IsBrowsable = isBrowsable;
            this.Category = category;
            this.Description = description;
            this.ObjectSource = 对象;
            this.EditorType = editorType;
            this.ConverterType = converterType;
        }

        protected void OnObjectSourceChanged()
        {
            if (this.PropertyInfos.Length != 0)
            {
                object obj2 = this.PropertyInfos[0].GetValue(this.d, null);
                if (this.eval_b == null)
                {
                    this.DefaultValue = obj2;
                }
                this.eval_c = obj2;
            }
        }

        protected void OnValueChanged()
        {
            if (this.d != null)
            {
                foreach (PropertyInfo info in this.PropertyInfos)
                {
                    info.SetValue(this.d, this.eval_c, null);
                }
            }
        }

        public void ResetValue()
        {
            this.Value = this.DefaultValue;
        }

        public string Category
        {
            [CompilerGenerated]
            get
            {
                return this.eval_j;
            }
            [CompilerGenerated]
            set
            {
                this.eval_j = value;
            }
        }

        public bool ConverterType
        {
            [CompilerGenerated]
            get
            {
                return this.eval_m;
            }
            [CompilerGenerated]
            set
            {
                this.eval_m = value;
            }
        }

        public object DefaultValue
        {
            get
            {
                return this.eval_b;
            }
            set
            {
                this.eval_b = value;
                if (this.eval_b != null)
                {
                    if (this.eval_c == null)
                    {
                        this.eval_c = this.eval_b;
                    }
                    if (this.ValueType == null)
                    {
                        this.ValueType = this.eval_b.GetType();
                    }
                }
            }
        }

        public string Description
        {
            [CompilerGenerated]
            get
            {
                return this.eval_i;
            }
            [CompilerGenerated]
            set
            {
                this.eval_i = value;
            }
        }

        public Type EditorType
        {
            [CompilerGenerated]
            get
            {
                return this.eval_l;
            }
            [CompilerGenerated]
            set
            {
                this.eval_l = value;
            }
        }

        public bool IsBrowsable
        {
            [CompilerGenerated]
            get
            {
                return this.eval_k;
            }
            [CompilerGenerated]
            set
            {
                this.eval_k = value;
            }
        }

        public bool IsReadOnly
        {
            [CompilerGenerated]
            get
            {
                return this.eval_h;
            }
            [CompilerGenerated]
            set
            {
                this.eval_h = value;
            }
        }

        public string Name
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
                if (this.PropertyNames == null)
                {
                    this.PropertyNames = new string[] { this.a };
                }
            }
        }

        public object ObjectSource
        {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
                this.OnObjectSourceChanged();
            }
        }

        protected PropertyInfo[] PropertyInfos
        {
            get
            {
                if (this.eval_e == null)
                {
                    Type type = this.ObjectSource.GetType();
                    this.eval_e = new PropertyInfo[this.PropertyNames.Length];
                    for (int i = 0; i < this.PropertyNames.Length; ++i)
                    {
                        this.eval_e[i] = type.GetProperty(this.PropertyNames[i]);
                    }
                }
                return this.eval_e;
            }
        }

        public string[] PropertyNames
        {
            [CompilerGenerated]
            get
            {
                return this.eval_f;
            }
            [CompilerGenerated]
            set
            {
                this.eval_f = value;
            }
        }

        public object Value
        {
            get
            {
                return this.eval_c;
            }
            set
            {
                this.eval_c = value;
                this.OnValueChanged();
            }
        }

        public Type ValueType
        {
            [CompilerGenerated]
            get
            {
                return this.eval_g;
            }
            [CompilerGenerated]
            set
            {
                this.eval_g = value;
            }
        }
    }
}

