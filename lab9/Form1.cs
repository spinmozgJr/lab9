using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Color firstLineColor = Color.Black;
        public Color firstAxisColor = Color.Black;
        public Color secondLineColor = Color.Black;
        
        public Form1()
        {
            InitializeComponent();
            cmbBoxXAxisType.SelectedIndex = 0;
            cmbBoxLineType1.SelectedIndex = 0;
            cmbBoxYAxisType.SelectedIndex = 0;
        }

        private void btnFileOpen1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    txtBoxX1.Text = reader.ReadLine();
                    txtBoxY1.Text = reader.ReadLine();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnColorLine1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            firstLineColor = colorDialog1.Color;
            txtBoxLineColor1.BackColor = firstLineColor;
        }

        private void btnColorAxis1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            firstAxisColor = colorDialog1.Color;
            txtBoxAxisColor1.BackColor = firstAxisColor;
        }

        private void btnColorLine2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            secondLineColor = colorDialog1.Color;
            txtBoxLineColor2.BackColor = secondLineColor;
        }

        private void btnFileOpen2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    txtBoxX2.Text = reader.ReadLine();
                    txtBoxY2.Text = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            CreateLineGraph(zedGraph);
            CreateScatterPlot(zedGraph);
        }

        public PointPairList GetList(string[] stringXValues, string[] stringYValues)
        {
            if (stringXValues.Length != stringYValues.Length)
            {
                MessageBox.Show("Количество х и у различны");
                return null;
            }

            double[] xValues = new double[stringXValues.Length];
            double[] yValues = new double[stringYValues.Length];
            PointPairList list = new PointPairList();

            for (int j = 0; j < stringXValues.Length; j++)
            {
                if (false == double.TryParse(stringXValues[j], out xValues[j]))
                {
                    MessageBox.Show("Не удалось преобразовать первую серию данных");
                    return null;
                }

                if (false == double.TryParse(stringYValues[j], out yValues[j]))
                {
                    MessageBox.Show("Не удалось преобразовать вторую серию данных");
                    return null;
                }
                list.Add(xValues[j], yValues[j]);
            }

            return list;
        }

        public void CreateLineGraph(ZedGraphControl zgc)
        {
            string[] stringXValues = txtBoxX1.Text.Split(' ');
            string[] stringYValues = txtBoxY1.Text.Split(' ');

            PointPairList list = GetList(stringXValues, stringYValues);
            if (list == null)
                return;

            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();
            // Set the titles and axis labels
            myPane.Title.Text = "Вариант 11";
            myPane.XAxis.Title.Text = "Ось X";
            myPane.YAxis.Title.Text = "Ось Y";

            LineItem myCurve = myPane.AddCurve("Parabola",
               list, firstLineColor, SymbolType.None);
            myCurve.Line.Style = (DashStyle)cmbBoxLineType1.SelectedIndex;

            // Set the Y axis intersect the X axis at an X value of 0.0
            myPane.XAxis.Cross = 0.0;
            myPane.YAxis.Cross = 0.0;

            myPane.XAxis.MajorGrid.IsZeroLine = true;
            myPane.YAxis.MajorGrid.IsZeroLine = true;
            myPane.YAxis.Color = firstAxisColor;

            switch (cmbBoxXAxisType.SelectedIndex)
            {
                case 0:
                    myPane.XAxis.Type = AxisType.Linear;
                    break;
                case 1:
                    myPane.XAxis.Type = AxisType.Log;
                    break;
                case 2:
                    myPane.XAxis.Type = AxisType.Date;
                    break;
                case 3:
                    myPane.XAxis.Type = AxisType.Ordinal;
                    break;
                case 4:
                    myPane.XAxis.Type = AxisType.Exponent;
                    break;
            }

            switch (cmbBoxYAxisType.SelectedIndex)
            {
                case 0:
                    myPane.YAxis.Type = AxisType.Linear;
                    break;
                case 1:
                    myPane.YAxis.Type = AxisType.Log;
                    break;
                case 2:
                    myPane.YAxis.Type = AxisType.Date;
                    break;
                case 3:
                    myPane.YAxis.Type = AxisType.Ordinal;
                    break;
                case 4:
                    myPane.YAxis.Type = AxisType.Exponent;
                    break;
            }

            //myPane.YAxis.Type = AxisType.Ordinal;

            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
            zgc.Refresh();
            zedGraph.Invalidate();
        }

        public void CreateScatterPlot(ZedGraphControl zgc)
        {
            string[] stringXValues = txtBoxX2.Text.Split(' ');
            string[] stringYValues = txtBoxY2.Text.Split(' ');

            PointPairList list = GetList(stringXValues, stringYValues);
            if (list == null)
                return;

            GraphPane myPane = zgc.GraphPane;

            LineItem myCurve = myPane.AddCurve("Scatter", list, secondLineColor, SymbolType.Diamond);

            myPane.YAxis.Cross = 0.0;
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Fill.Color = secondLineColor;

            myCurve.Symbol.Fill.Type = FillType.Solid;

            zgc.AxisChange();
            zgc.Refresh();
            zedGraph.Invalidate();
        }
    }
}
