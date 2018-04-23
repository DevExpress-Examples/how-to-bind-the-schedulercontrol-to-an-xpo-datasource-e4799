Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DXSample.DataObjects
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Threading
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace DXSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			ThreadPool.QueueUserWorkItem(Function(o) AnonymousMethod1(o))
		End Sub
		
		Private Function AnonymousMethod1(ByVal o As Object) As Boolean
			XpoDefault.Session = Nothing
			XpoDefault.DataLayer = XpoDefault.GetDataLayer("http://localhost:57108/SchedulerDataService.svc", AutoCreateOption.SchemaAlreadyExists)
			Using uow As New UnitOfWork()
				uow.Dictionary.CollectClassInfos(GetType(MainPage).Assembly)
				uow.TypesManager.EnsureIsTypedObjectValid()
				Dispatcher.BeginInvoke(AddressOf BeginInitializeDataSource)
			End Using
			Return True
		End Function

		Private Sub BeginInitializeDataSource()
			Dim uow As New UnitOfWork()
			Dim appointments As New XPCollection(Of Appointments)(uow)
			appointments.DeleteObjectOnRemove = True
			Dim resources As New XPCollection(Of DXSample.DataObjects.Resources)(uow)
			resources.DeleteObjectOnRemove = True
			appointments.LoadAsync()
			resources.LoadAsync()
			Me.DataContext = New CollectionsContainer() With {.Appointments = appointments, .Resources = resources, .UOW = uow}
		End Sub

		Private Sub OnAppointmentsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs)
			TryCast(DataContext, CollectionsContainer).Commit()
		End Sub
	End Class

	Public Class CollectionsContainer
		Private privateAppointments As XPCollection(Of Appointments)
		Public Property Appointments() As XPCollection(Of Appointments)
			Get
				Return privateAppointments
			End Get
			Set(ByVal value As XPCollection(Of Appointments))
				privateAppointments = value
			End Set
		End Property
		Private privateResources As XPCollection(Of DXSample.DataObjects.Resources)
		Public Property Resources() As XPCollection(Of DXSample.DataObjects.Resources)
			Get
				Return privateResources
			End Get
			Set(ByVal value As XPCollection(Of DXSample.DataObjects.Resources))
				privateResources = value
			End Set
		End Property
		Private privateUOW As UnitOfWork
		Public Property UOW() As UnitOfWork
			Get
				Return privateUOW
			End Get
			Set(ByVal value As UnitOfWork)
				privateUOW = value
			End Set
		End Property
		Public Sub Commit()
			UOW.CommitChangesAsync(Function(ex) AnonymousMethod2(ex))
		End Sub
		
		Private Function AnonymousMethod2(ByVal ex As Object) As Boolean
			If ex IsNot Nothing Then
				MessageBox.Show(ex.ToString())
			End If
			Return True
		End Function
	End Class
End Namespace
