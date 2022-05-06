using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Shared
{
    public class ConferenceModel
    {
        public ConferenceModel()
        {
            Start = DateTime.Now;
        }
        public DateTime Start { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        [DisplayName("Attendee total")]
        public int AttendeeTotal { get; set; }
    }
}
