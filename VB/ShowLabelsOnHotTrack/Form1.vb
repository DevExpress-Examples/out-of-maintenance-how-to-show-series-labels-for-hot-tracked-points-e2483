#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...
#End Region ' #usings

Namespace ShowLabelsOnHotTrack
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

#Region "#code"
Private m_HotTrackedPoint As SeriesPoint

Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, _ 
ByVal e As HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
	Dim point As SeriesPoint = TryCast(e.AdditionalObject, SeriesPoint)
	If (Not Object.ReferenceEquals(point, m_HotTrackedPoint)) Then
		m_HotTrackedPoint = point
		chartControl1.Refresh()
	End If
End Sub

Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, _ 
ByVal e As CustomDrawSeriesPointEventArgs) Handles chartControl1.CustomDrawSeriesPoint
	e.LabelText = ""
	If e.SeriesPoint Is m_HotTrackedPoint Then
		e.LabelText = e.SeriesPoint.Values(0).ToString()
	End If
End Sub
#End Region ' #code

	End Class
End Namespace
