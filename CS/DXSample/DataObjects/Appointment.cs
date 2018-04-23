using DevExpress.Xpo;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DXSample.DataObjects {
    [Persistent("Appointments")]
    public class Appointments : XPLiteObject {
        public Appointments(Session session) : base(session) { }

        [Key(true)]
        public int UniqueID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int Type { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public int ResourceId { get; set; }
        public string ResourceIds { get; set; }
    }
}
