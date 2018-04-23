Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_3DSplineChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim SplineChart3D As New ChartControl()

			' Add a spline series to it.
			Dim series1 As New Series("Series 1", ViewType.Spline3D)

			' Add points to the series.
			series1.Points.Add(New SeriesPoint("A", 12))
			series1.Points.Add(New SeriesPoint("B", 4))
			series1.Points.Add(New SeriesPoint("C", 17))
			series1.Points.Add(New SeriesPoint("D", 7))
			series1.Points.Add(New SeriesPoint("E", 12))
			series1.Points.Add(New SeriesPoint("F", 4))
			series1.Points.Add(New SeriesPoint("G", 17))
			series1.Points.Add(New SeriesPoint("H", 7))

			' Add both series to the chart.
			SplineChart3D.Series.Add(series1)

			' Access labels of the series.
			CType(series1.Label, Line3DSeriesLabel).Visible = True
			CType(series1.Label, Line3DSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

			' Access another series options.
            series1.Label.PointOptions.PointView = PointView.ArgumentAndValues

			' Customize the view-type-specific properties of the series.
			Dim myView As Spline3DSeriesView = CType(series1.View, Spline3DSeriesView)
			myView.LineWidth = 5
			myView.LineThickness = 4
			myView.LineTensionPercent = 50

			' Access the diagram's options.
			CType(SplineChart3D.Diagram, XYDiagram3D).ZoomPercent = 110
			CType(SplineChart3D.Diagram, XYDiagram3D).VerticalScrollPercent = 10

			' Add a title to the chart and hide the legend.
			Dim chartTitle1 As New ChartTitle()
			chartTitle1.Text = "3D Spline Chart"
			SplineChart3D.Titles.Add(chartTitle1)
			SplineChart3D.Legend.Visible = False

			' Add the chart to the form.
			SplineChart3D.Dock = DockStyle.Fill
			Me.Controls.Add(SplineChart3D)
		End Sub

	End Class
End Namespace