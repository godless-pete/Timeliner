using System.Collections.Generic;

namespace Timeliner.StorageClasses
{
    public class Timeline
    {
        IList<TimelineEvent> _events;

        public Timeline()
        {
            _events = new List<TimelineEvent>();
        }

        public IList<TimelineEvent> Events
        {
            get { return _events; }
            set { _events = value; }
        }

    }
}
