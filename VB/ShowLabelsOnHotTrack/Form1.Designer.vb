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
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(15.54R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(17.1R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(12.1R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(9.87R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (DirectCast(10.12R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (DirectCast(17.3R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (DirectCast(14.56R, Object))})
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AppearanceNameSerializable = "In A Fog"
            Me.chartControl1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7})
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(284, 264)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 264)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

