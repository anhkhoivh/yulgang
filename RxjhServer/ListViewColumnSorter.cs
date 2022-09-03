using System.Collections;
using System.Windows.Forms;

namespace RxjhServer
{
	public class ListViewColumnSorter : IComparer
	{
		private int eval_a = 0;

		private SortOrder eval_b = SortOrder.None;

		private CaseInsensitiveComparer eval_c = new CaseInsensitiveComparer();

		public SortOrder Order
		{
			get
			{
				return eval_b;
			}
			set
			{
				eval_b = value;
			}
		}

		public int SortColumn
		{
			get
			{
				return eval_a;
			}
			set
			{
				eval_a = value;
			}
		}

		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			int num = eval_c.Compare(listViewItem.SubItems[eval_a].Text, listViewItem2.SubItems[eval_a].Text);
			if (eval_b == SortOrder.Ascending)
			{
				return num;
			}
			if (eval_b == SortOrder.Descending)
			{
				return -num;
			}
			return 0;
		}
	}
}
