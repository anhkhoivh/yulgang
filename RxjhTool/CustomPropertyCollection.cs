using RxjhTool;

namespace RxjhTool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing.Design;

    public class CustomPropertyCollection : List<CustomProperty>, ICustomTypeDescriptor
    {
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public PropertyDescriptorCollection GetProperties()
        {
            return TypeDescriptor.GetProperties(this, true);
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection descriptors = new PropertyDescriptorCollection(null);
            foreach (CustomProperty property in this)
            {
                List<Attribute> list = new List<Attribute>();
                list.Add(new CategoryAttribute(property.Category));
                if (!property.IsBrowsable)
                {
                    list.Add(new BrowsableAttribute(property.IsBrowsable));
                }
                if (property.IsReadOnly)
                {
                    list.Add(new ReadOnlyAttribute(property.IsReadOnly));
                }
                if (property.EditorType != null)
                {
                    list.Add(new EditorAttribute(property.EditorType, typeof(UITypeEditor)));
                }
                if (property.ConverterType)
                {
                    list.Add(new TypeConverterAttribute(typeof(SpellingOptionsConverter)));
                }
                descriptors.Add(new CustomPropertyDescriptor(property, list.ToArray()));
            }
            return descriptors;
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }
    }
}

