using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_3DSplineChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl SplineChart3D = new ChartControl();

            // Add a spline series to it.
            Series series1 = new Series("Series 1", ViewType.Spline3D);

            // Add points to the series.
            series1.Points.Add(new SeriesPoint("A", 12));
            series1.Points.Add(new SeriesPoint("B", 4));
            series1.Points.Add(new SeriesPoint("C", 17));
            series1.Points.Add(new SeriesPoint("D", 7));
            series1.Points.Add(new SeriesPoint("E", 12));
            series1.Points.Add(new SeriesPoint("F", 4));
            series1.Points.Add(new SeriesPoint("G", 17));
            series1.Points.Add(new SeriesPoint("H", 7));

            // Add both series to the chart.
            SplineChart3D.Series.Add(series1);

            // Access labels of the series.
            ((Line3DSeriesLabel)series1.Label).Visible = true;
            ((Line3DSeriesLabel)series1.Label).ResolveOverlappingMode =
                ResolveOverlappingMode.Default;

            // Access another series options.
            series1.Label.PointOptions.PointView = PointView.ArgumentAndValues;

            // Customize the view-type-specific properties of the series.
            Spline3DSeriesView myView = (Spline3DSeriesView)series1.View;
            myView.LineWidth = 5;
            myView.LineThickness = 4;
            myView.LineTensionPercent = 50;

            // Access the diagram's options.
            ((XYDiagram3D)SplineChart3D.Diagram).ZoomPercent = 110;
            ((XYDiagram3D)SplineChart3D.Diagram).VerticalScrollPercent = 10;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Spline Chart";
            SplineChart3D.Titles.Add(chartTitle1);
            SplineChart3D.Legend.Visible = false;

            // Add the chart to the form.
            SplineChart3D.Dock = DockStyle.Fill;
            this.Controls.Add(SplineChart3D);
        }

    }
}