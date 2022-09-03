namespace RxjhTool
{
    using System;
    using System.ComponentModel.Design;

    public class My奖励物品CollectionEditor : CollectionEditor
    {
        public My奖励物品CollectionEditor(Type type) : base(type)
        {
        }

        protected override string GetDisplayText(object value)
        {
            if (value is 任务奖励物品类)
            {
                任务奖励物品类 任务奖励物品类 = (任务奖励物品类) value;
                return (任务奖励物品类.物品ID + " 数量 " + 任务奖励物品类.物品数量);
            }
            return value.ToString();
        }
    }
}

