using System.ComponentModel;
using System.Windows.Forms;

namespace RxjhServer
{
	public class FlickerFreePanel : Panel
	{
		private IContainer eval_a_a;

		public FlickerFreePanel()
		{
			SetStyle(ControlStyles.ResizeRedraw, value: true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
			SetStyle(ControlStyles.DoubleBuffer, value: true);
			SetStyle(ControlStyles.UserPaint, value: true);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && eval_a_a != null)
			{
				eval_a_a.Dispose();
			}
			base.Dispose(disposing);
		}

		private void eval_a()
		{
			eval_a_a = new Container();
		}
	}
}
