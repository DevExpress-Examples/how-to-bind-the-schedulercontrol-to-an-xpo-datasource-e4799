Imports Microsoft.VisualBasic
Imports DevExpress.Xpo
Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace DXSample.DataObjects
	<Persistent("Resources")> _
	Public Class Resources
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private privateUniqueID As Integer
		<Key(True)> _
		Public Property UniqueID() As Integer
			Get
				Return privateUniqueID
			End Get
			Set(ByVal value As Integer)
				privateUniqueID = value
			End Set
		End Property
		Private privateResourceId As Integer
		Public Property ResourceId() As Integer
			Get
				Return privateResourceId
			End Get
			Set(ByVal value As Integer)
				privateResourceId = value
			End Set
		End Property
		Private privateResourceName As String
		Public Property ResourceName() As String
			Get
				Return privateResourceName
			End Get
			Set(ByVal value As String)
				privateResourceName = value
			End Set
		End Property
	End Class
End Namespace
