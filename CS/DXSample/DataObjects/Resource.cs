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
    [Persistent("Resources")]
    public class Resources : XPLiteObject {
        public Resources(Session session) : base(session) { }

        [Key(true)]
        public int UniqueID { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
    }
}
