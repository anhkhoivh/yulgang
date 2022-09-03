using System;
using System.ComponentModel.Design;
using RxjhTool;

namespace RxjhTool
{
    public class My需要物品CollectionEditor : CollectionEditor
    {
        public My需要物品CollectionEditor(Type type) : base(type)
        {
        }

        protected override string GetDisplayText(object value)
        {
            if (value is 任务需要物品类)
            {
                任务需要物品类 任务需要物品类 = (任务需要物品类) value;
                return (任务需要物品类.物品ID + " 数量 " + 任务需要物品类.物品数量);
            }
            return value.ToString();
        }
    }
}

