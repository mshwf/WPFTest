using LineCharts;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for WndBehavior.xaml
    /// </summary>
    class VM
    {
        public string Name { get; set; }
    }
    public partial class WndBehavior : Window
    {
        private ChartStyleGridlines cs;
        private Legend lg;
        private DataCollection dc;
        private DataSeries ds;
        public WndBehavior()
        {
            InitializeComponent();
            //AddChart();
        }

        private void SelectedSampleChanged(object sender, RoutedEventArgs e)
        {

        }

        private void grid1_PreviewQueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {

        }
        //private void AddChart()
        //{
        //    ChartStyle
        //    cs = new ChartStyleGridlines();
        //    lg = new Legend();
        //    dc = new DataCollection();
        //    ds = new DataSeries();
        //    cs.ChartCanvas = chartCanvas;
        //    cs.TextCanvas = textCanvas;
        //    cs.Title = "Sine and Cosine Chart";
        //    cs.Xmin = 0;
        //    cs.Xmax = 7;
        //    cs.Ymin = -1.5;
        //    cs.Ymax = 1.5;
        //    cs.YTick = 0.5;
        //    cs.GridlinePattern = ChartStyleGridlines.GridlinePatternEnum.Dot;
        //    cs.GridlineColor = Brushes.Black;
        //    cs.AddChartStyle(tbTitle, tbXLabel, tbYLabel);
        //    // Draw Sine curve:
        //    ds.LineColor = Brushes.Blue;
        //    ds.LineThickness = 1;
        //    ds.SeriesName = "Sine";
        //    for (int i = 0; i < 70; i++)
        //    {
        //        double x = i / 5.0;
        //        double y = Math.Sin(x);
        //        ds.LineSeries.Points.Add(new Point(x, y));
        //    }
        //    dc.DataList.Add(ds);
        //    // Draw cosine curve:
        //    ds = new DataSeries();
        //    ds.LineColor = Brushes.Red;
        //    ds.SeriesName = "Cosine";
        //    ds.LinePattern = DataSeries.LinePatternEnum.DashDot;
        //    ds.LineThickness = 2;
        //    for (int i = 0; i < 70; i++)
        //    {
        //        double x = i / 5.0;
        //        double y = Math.Cos(x);
        //        ds.LineSeries.Points.Add(new Point(x, y));
        //    }
        //    dc.DataList.Add(ds);
        //    // Draw sine^2 curve:
        //    ds = new DataSeries();
        //    ds.LineColor = Brushes.DarkGreen;
        //    ds.SeriesName = "Sine^2";
        //    ds.LinePattern = DataSeries.LinePatternEnum.Dot;
        //    ds.LineThickness = 2;
        //    for (int i = 0; i < 70; i++)
        //    {
        //        double x = i / 5.0;
        //        double y = Math.Sin(x) * Math.Sin(x);
        //        ds.LineSeries.Points.Add(new Point(x, y));
        //    }
        //    dc.DataList.Add(ds);
        //    dc.AddLines(cs);
        //    lg.LegendCanvas = legendCanvas;
        //    lg.IsLegend = true;
        //    lg.IsBorder = true;
        //    lg.LegendPosition = Legend.LegendPositionEnum.NorthWest;
        //    lg.AddLegend(cs.ChartCanvas, dc);
        //}

    }
}
