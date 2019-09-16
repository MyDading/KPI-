using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //需要添加的命名空间
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KPI柱状图绘制
{
    public partial class Form2 : Form
    {

        static int aaa = 0;

        public Form2()
        {
            InitializeComponent();
            InitChart();
        }



        private void InitChart()
        {
            DateTime time = DateTime.Now;
            textBox1.Text = "开始时间：" + time.ToString();
            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Spline;

            this.chart1.ChartAreas[0].AxisY.Maximum = 10;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            this.chart1.ChartAreas[0].AxisX.ScaleView.Size = 5;
            this.chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            this.chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            this.chart1.Series[0].Color = Color.Red;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.chart1.Series[0].Points.Clear();
            string con, sql;
            con = "server=127.0.0.1;user=root;database=users;port=3306;password=sas124578";
            MySqlConnection mycon = new MySqlConnection(con);
            mycon.Open();
            sql = "select * from receive_data";
            MySqlDataAdapter myda = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            DataSet myds = new DataSet();
            myda.Fill(dt);
            myda.Fill(myds, "receive_data");

            Series series = chart1.Series[0];

            foreach (DataRow row in dt.Rows)
            {

                List<short> www = new List<short>();
                short point = short.Parse(row["net1_receive_count"].ToString());
                series.Points.AddXY(DateTime.Now, point);
                www.Add(point);
                aaa++;
                if (aaa == www.Count)
                {
                    textBox1.Text = aaa.ToString() + www.Count.ToString();
                    this.timer1.Stop();
                }

            }

            this.chart1.ChartAreas[0].AxisX.ScaleView.Position = series.Points.Count - 6;

            //throw new NotImplementedException();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
        }

    

        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }
    }
}
