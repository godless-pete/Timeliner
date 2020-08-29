using System;
using System.Windows.Forms;
using Timeliner.StorageClasses;

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

        private void butLoadTimeline_Click(object sender, EventArgs e)
        {
            var timeline = new Timeline() 
            { 
                Events = GetTimelineEvents() 
            };

            timelineControl1.SetTimeline(timeline);
        }
        
        protected TimelineEvent[] GetTimelineEvents() => new TimelineEvent[]
            {
                new TimelineEvent("1980-01-01", "1980"),
                new TimelineEvent("1990-01-01", "1990"),
                new TimelineEvent("2000-01-01", "2000"),
                new TimelineEvent("2010-01-01", "2010"),            
            };


    }
}
