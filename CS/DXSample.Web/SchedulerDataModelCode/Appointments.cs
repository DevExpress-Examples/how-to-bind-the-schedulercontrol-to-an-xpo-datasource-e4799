using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace DXSample.Web.SchedulerDB {

    public partial class Appointments {
        public Appointments(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
