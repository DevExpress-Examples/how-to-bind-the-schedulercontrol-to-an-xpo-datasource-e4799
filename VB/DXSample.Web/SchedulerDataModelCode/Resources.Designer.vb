'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Namespace DXSample.Web.SchedulerDB

	Partial Public Class Resources
		Inherits XPLiteObject
		Private fUniqueID As Integer
		<Key(True)> _
		Public Property UniqueID() As Integer
			Get
				Return fUniqueID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("UniqueID", fUniqueID, value)
			End Set
		End Property
		Private fResourceID As Integer
		Public Property ResourceID() As Integer
			Get
				Return fResourceID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("ResourceID", fResourceID, value)
			End Set
		End Property
		Private fResourceName As String
		<Size(50)> _
		Public Property ResourceName() As String
			Get
				Return fResourceName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ResourceName", fResourceName, value)
			End Set
		End Property
		Private fColor As Integer
		Public Property Color() As Integer
			Get
				Return fColor
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("Color", fColor, value)
			End Set
		End Property
		Private fImage() As Byte
		<Size(SizeAttribute.Unlimited)> _
		Public Property Image() As Byte()
			Get
				Return fImage
			End Get
			Set(ByVal value As Byte())
				SetPropertyValue(Of Byte())("Image", fImage, value)
			End Set
		End Property
		Private fCustomField1 As String
		<Size(SizeAttribute.Unlimited)> _
		Public Property CustomField1() As String
			Get
				Return fCustomField1
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("CustomField1", fCustomField1, value)
			End Set
		End Property
	End Class

End Namespace
