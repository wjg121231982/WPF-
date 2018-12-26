using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.DataVisualization.Charting;
namespace WPF_使用WinForm_Chart控件
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Chart C = new Chart();
            InitAttMedChart(chartAttMed);
        }
        public static void InitAttMedChart(Chart chartAttMed)
        {

             ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
           Title title1 = new Title();

          
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(200, 230, 185);
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
           // chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(200, 230, 185);


            chartArea1.AxisX.ScaleView.Size = 100D;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisX.ScrollBar.Enabled = false;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 20D;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 80F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 10F;

            chartAttMed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.BackColor = System.Drawing.Color.Transparent;
            chartAttMed.Legends.Add(legend1);
            chartAttMed.Name = "chartAttMed";
            chartAttMed.Size = new System.Drawing.Size(759, 259);
            chartAttMed.TabIndex = 0;
            chartAttMed.Text = "chart1";

            title1.Font = new System.Drawing.Font("微软雅黑", 12);
            title1.Text = "专注度/放松度曲线";
            chartAttMed.Titles.Add(title1);



            chartAttMed.Series.Clear();
           
            Series attSeries = new Series("seriesAttention");
            attSeries.BorderWidth = 2;
            attSeries.ChartType = SeriesChartType.Spline;
            attSeries.LegendText = "专注度";
            attSeries.Color = System.Drawing.Color.Red;
            attSeries.ChartArea = "ChartArea1";// chartAttMed.ChartAreas[0].Name;
            DataPoint p = new DataPoint(10,22);
            DataPoint p1 = new DataPoint(2, 21);
            attSeries.Points.Add(p);
            attSeries.Points.Add(p1);
            Series medSeries = new Series("seriesMeditation");

            medSeries.BorderWidth = 2;
            medSeries.Color = System.Drawing.Color.Green;
            medSeries.ChartType = SeriesChartType.Spline;
            medSeries.LegendText = "放松度";
            medSeries.ChartArea = chartAttMed.ChartAreas[0].Name;//"ChartArea2"; //

            chartAttMed.Series.Add(attSeries);
            chartAttMed.Series.Add(medSeries);

           // chartAttMed.BackColor = System.Drawing.Color.FromArgb(209, 235, 201);
            chartAttMed.BackColor = System.Drawing.Color.White;
            chartAttMed.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            //chartAttMed.BackSecondaryColor = System.Drawing.Color.FromArgb(200, 230, 185);
            chartAttMed.BackSecondaryColor = System.Drawing.Color.White;
            //eeg
        }

    }
}
