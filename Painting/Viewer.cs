using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painting
{
	public partial class Viewer : Form
	{
		public Viewer()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (DrawAction != null)
				DrawAction(e.Graphics);
		}

		public Action<Graphics> DrawAction
		{
			private get;
			set;
		}
	}
}
