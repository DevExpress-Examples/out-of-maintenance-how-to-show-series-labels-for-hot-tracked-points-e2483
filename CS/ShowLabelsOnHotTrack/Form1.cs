#region #usings
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...
#endregion #usings

namespace ShowLabelsOnHotTrack {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #code
SeriesPoint m_HotTrackedPoint;

void chartControl1_ObjectHotTracked(object sender, HotTrackEventArgs e) {
    SeriesPoint point = e.AdditionalObject as SeriesPoint;
    if (!Object.ReferenceEquals(point, m_HotTrackedPoint)) {
        m_HotTrackedPoint = point;
        chartControl1.Refresh();
    }
}

void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
    e.LabelText = "";
    if (e.SeriesPoint == m_HotTrackedPoint) {
        e.LabelText = e.SeriesPoint.Values[0].ToString();
    }
}
#endregion #code

    }
}
