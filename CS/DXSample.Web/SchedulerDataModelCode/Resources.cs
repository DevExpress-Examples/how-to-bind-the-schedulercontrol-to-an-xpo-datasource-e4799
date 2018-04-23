using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace DXSample.Web.SchedulerDB {

    public partial class Resources {
        public Resources(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
