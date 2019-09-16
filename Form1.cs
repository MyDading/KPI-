using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.IO;//用于文件存取 
using System.Data;//用于数据访问 
using System.Drawing;//提供画GDI+图形的基本功能 
using System.Drawing.Text;//提供画GDI+图形的高级功能 
using System.Drawing.Drawing2D;//提供画高级二维，矢量图形功能 
using System.Drawing.Imaging;//提供画GDI+图形的高级功能 

namespace KPI柱状图绘制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       /* private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1.Series.Clear();
            this.chart1.BackColor = Color.Black;
            Series series = new Series();
            series.XValueType = ChartValueType.Time;
            series.LabelForeColor = Color.White;
            series.ChartType = SeriesChartType.Line;
            series.IsValueShownAsLabel = true;
            this.chart1.Series.Add(series);

            ChartArea area = this.chart1.ChartAreas[0];
            area.BackColor = Color.Black;

            Axis axisX = this.chart1.ChartAreas[0].AxisX;
            axisX.IsStartedFromZero = true;
            axisX.LineWidth = 2;
            axisX.Maximum = 400; //可不写，它会自动技算，但效果不好
            //axisX.Minimum = 0;　//如果写这个，会不从0开始
            axisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            axisX.Interval = 1;
            axisX.LabelStyle = new LabelStyle() { ForeColor = Color.White };
            axisX.LineColor = Color.White;
            axisX.IsMarginVisible = false;

            Axis axisY = this.chart1.ChartAreas[0].AxisY;

            axisY.LabelStyle = new LabelStyle() { ForeColor = Color.White };
            axisY.LineColor = Color.White;

            this.CreateChart(series);
        }
        private void CreateChart(Series series)
        {
            try
            {
                string connectionString = "server=127.0.0.1;user=root;database=users;port=3306;password=sas124578;";
                MySqlConnection conection = new MySqlConnection(connectionString);
                conection.Open();
                string selectCommandText = "select * 温度,时间 from 表名";
                MySqlDataAdapter da = new MySqlDataAdapter(selectCommandText, conection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conection.Close();

                foreach (DataRow row in dt.Rows)
                {
                    float temperature = float.Parse(row["温度"].ToString());
                    DateTime time = DateTime.Parse(row["时间"].ToString());
                    series.Points.AddXY(time, temperature);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
