using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DXSample.Web.SchedulerDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DXSample.Web {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SchedulerDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SchedulerDataService.svc or SchedulerDataService.svc.cs at the Solution Explorer and start debugging.
    public class SchedulerDataService : DataStoreService {
        private static IDataStore Provider = XpoDefault.GetConnectionProvider(ConnectionHelper.ConnectionString, AutoCreateOption.SchemaAlreadyExists);
        static SchedulerDataService() { }
        public SchedulerDataService() : base(SchedulerDataService.Provider) { }
        public void DoWork(){ }
    }
}
