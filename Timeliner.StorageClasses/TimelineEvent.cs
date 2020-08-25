using System;

namespace Timeliner.StorageClasses
{
    public class TimelineEvent
    {
        public TimelineEvent()
        {
        }

        public TimelineEvent(string dateStr, string title)
        {
            DateStr = dateStr;
            Title = title;
        }

        public string DateStr 
        {
            set { Date = DateTime.Parse(value); }
            get { return Date.ToShortDateString(); } 
        }

        public DateTime Date { get; set; }

        public string Title { get; set; }

    }
}
