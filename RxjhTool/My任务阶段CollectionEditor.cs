namespace RxjhTool
{
    using System;
    using System.ComponentModel.Design;

    public class My任务阶段CollectionEditor : CollectionEditor
    {
        public My任务阶段CollectionEditor(Type type) : base(type)
        {
        }

        protected override string GetDisplayText(object value)
        {
            if (value is 任务阶段类)
            {
                任务阶段类 任务阶段类 = (任务阶段类) value;
                return 任务阶段类.任务阶段内容;
            }
            return value.ToString();
        }
    }
}

