using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DXSample.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DXSample {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            ThreadPool.QueueUserWorkItem(o => {
                XpoDefault.Session = null;
                XpoDefault.DataLayer = XpoDefault.GetDataLayer("http://localhost:57108/SchedulerDataService.svc", AutoCreateOption.SchemaAlreadyExists);
                using(UnitOfWork uow = new UnitOfWork()) {
                    uow.Dictionary.CollectClassInfos(typeof(MainPage).Assembly);
                    uow.TypesManager.EnsureIsTypedObjectValid();
                    Dispatcher.BeginInvoke(BeginInitializeDataSource);
                }
            });
        }

        void BeginInitializeDataSource() {
            UnitOfWork uow = new UnitOfWork();
            XPCollection<Appointments> appointments = new XPCollection<Appointments>(uow);
            appointments.DeleteObjectOnRemove = true;
            XPCollection<DXSample.DataObjects.Resources> resources = new XPCollection<DXSample.DataObjects.Resources>(uow);
            resources.DeleteObjectOnRemove = true;
            appointments.LoadAsync();
            resources.LoadAsync();
            this.DataContext = new CollectionsContainer() { Appointments = appointments, Resources = resources, UOW = uow };
        }

        private void OnAppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e) {
            (DataContext as CollectionsContainer).Commit();
        }
    }

    public class CollectionsContainer {
        public XPCollection<Appointments> Appointments { get; set; }
        public XPCollection<DXSample.DataObjects.Resources> Resources { get; set; }
        public UnitOfWork UOW { get; set; }
        public void Commit() {
            UOW.CommitChangesAsync((ex) => {
                if(ex != null) {
                    MessageBox.Show(ex.ToString());
                }
            });
        }
    }
}
