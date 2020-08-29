using System;
using System.Windows.Forms;

namespace Timeliner
{
    public partial class TimelinerForm : Form
    {
        public TimelinerForm()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            timelineControl1.Invalidate();
        }
    }
}
