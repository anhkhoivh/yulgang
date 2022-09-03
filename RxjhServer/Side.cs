using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class Side : Form
	{
		public Side()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			SuspendLayout();
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.ClientSize = new System.Drawing.Size(356, 223);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Side";
			Text = "许可协议";
			ResumeLayout(performLayout: false);
		}
	}
}
