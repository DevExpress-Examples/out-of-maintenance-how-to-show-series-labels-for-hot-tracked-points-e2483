namespace ShowLabelsOnHotTrack {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(15.54D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(17.1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(12.1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(9.87D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("E", new object[] {
            ((object)(10.12D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("F", new object[] {
            ((object)(17.3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("G", new object[] {
            ((object)(14.56D))});
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "In A Fog";
            this.chartControl1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7});
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(284, 264);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chartControl1_ObjectHotTracked);
            this.chartControl1.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chartControl1_CustomDrawSeriesPoint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

