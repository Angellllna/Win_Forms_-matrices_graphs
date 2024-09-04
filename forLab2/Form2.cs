using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace forLab2
{
    public partial class Form2 : Form
    {

        int[,] matrix1;
        int[,] matrix2;
        public Form2(int[,] matrix1)
        {
            this.matrix1 = matrix1;
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            ResultSeries(matrix1, "Matrix 1");
            chart1.Titles.Add("Number of unique elements by rows");
            chart1.ChartAreas[0].AxisX.Title = "Row index";
        }
        void ResultSeries(int[,] matrix, string name)
        {
            var series = new Series { ChartType = SeriesChartType.Column, Name = name };
            var list = new List<int> ();
            double m = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                list.Clear();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    list.Add(Math.Abs(matrix[i, j]));
                }
                list.Sort();
                if (list.Count % 2 == 0)
                    m = (double)(list[list.Count / 2] + list[list.Count / 2 - 1]) / 2.0;
                else
                    m = list[list.Count / 2];
                series.Points.Add(m);
            }

            chart1.Series.Add(series);
        }

        
    }
}
