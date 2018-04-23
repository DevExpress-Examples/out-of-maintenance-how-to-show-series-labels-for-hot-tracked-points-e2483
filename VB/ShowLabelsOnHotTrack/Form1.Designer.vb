Imports Microsoft.VisualBasic
Imports System
Namespace ShowLabelsOnHotTrack
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(15.54R))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(17.1R))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(12.1R))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(9.87R))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (CObj(10.12R))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (CObj(17.3R))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (CObj(14.56R))})
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.AppearanceName = "In A Fog"
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			sideBySideBarSeriesLabel1.LineVisible = True
			series1.Label = sideBySideBarSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7})
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel2.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chartControl1.Size = New System.Drawing.Size(284, 264)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.ObjectHotTracked += New DevExpress.XtraCharts.HotTrackEventHandler(Me.chartControl1_ObjectHotTracked);
'			Me.chartControl1.CustomDrawSeriesPoint += New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(Me.chartControl1_CustomDrawSeriesPoint);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

