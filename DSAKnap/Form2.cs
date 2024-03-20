using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAKnap
{
    public partial class ChartForm : Form
    {
        /*string[] ItemName = new string[20];
        double[] ben = new double[20];
        double[] wei = new double[20];*/
        public ChartForm(string [] items ,double [] weight,double [] benifit)
        {
            Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} : ({1:P})", chartpoint.Instance, chartpoint.Participation);
           
            InitializeComponent();
            try
            {
                for(int i = 0; i < items.Length; i++)
                {
                    Weight_Chart.Series.Add(new PieSeries
                    {
                        Title = items[i],
                        Values = new ChartValues<double>() { (int)weight[i] },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });

                    Benefit_Chart.Series.Add(new PieSeries
                    {
                        Title = items[i],
                        Values = new ChartValues<double>() { (int)benifit[i] },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });
                }
                

                //iterate over the items array 
                /*for (int i = 0, j = 0; i < items.Length; i++, ++j)
                {
                    // add data to the "Weight" series
                    Weight_Chart.Series[j].Values.Add(weight[i]);

                    // add data to the "Benifit" series
                    Benefit_Chart.Series[j].Values.Add(benifit[i]);
                }*/
            }
            catch (Exception)
            {
               MessageBox.Show("Enter data to view Charts values");
                
            }
        }

        private void Exit_Lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Weight_Chart_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
