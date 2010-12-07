using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painting
{
	public partial class Viewer : Form
	{
		private Timer _timer;

		public Viewer()
		{
			InitializeComponent();
			DrawAction = delegate { };
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			DrawAction(e.Graphics);
		}

		public Action<Graphics> DrawAction
		{
			private get;
			set;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			// Every second we force this window to become the top most window.
			_timer = new Timer { Interval = 1000 };
			_timer.Tick += delegate { BringToFront(); };
			_timer.Start();
		}
	}
}
