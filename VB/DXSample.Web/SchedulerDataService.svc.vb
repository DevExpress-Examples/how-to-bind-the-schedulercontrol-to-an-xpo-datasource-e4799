Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DXSample.Web.SchedulerDB
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Text

Namespace DXSample.Web
	' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SchedulerDataService" in code, svc and config file together.
	' NOTE: In order to launch WCF Test Client for testing this service, please select SchedulerDataService.svc or SchedulerDataService.svc.cs at the Solution Explorer and start debugging.
	Public Class SchedulerDataService
		Inherits DataStoreService
		Private Shared Provider As IDataStore = XpoDefault.GetConnectionProvider(ConnectionHelper.ConnectionString, AutoCreateOption.SchemaAlreadyExists)
		Shared Sub New()
		End Sub
		Public Sub New()
			MyBase.New(SchedulerDataService.Provider)
		End Sub
		Public Sub DoWork()
		End Sub
	End Class
End Namespace
