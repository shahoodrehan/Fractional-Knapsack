using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DSAKnap
{
    public partial class MainForm : MaterialForm
    {
        private double[] weight;
        private double[] benefit;
        private double[] ratio;
        private string[] itemName;
        private double knapWeight = 25;  //Maximum weight of Knapsack
        private double[] selectedWei;  //Selected weight and benefit
        private int len;
        private double[] weightPercnt;  // Selected weight percentage
        private double[] benifitPercnt;  // Selected benefit percentage
        private string itemValue;
        private double[] selectedBen;
        private string items;
        private string itemWeight;
        MainForm form;

        // Property that returns a clone of the DataGridView control
        /*public DataTable Data
        {
            get { return dataGrid.DataSource as DataTable; }
        }
        public DataGridView datagridview
        {
            get { return dataGrid; }
            set { dataGrid = (Guna.UI2.WinForms.Guna2DataGridView) value; }
        }*/
        public string[] ItemName { get => itemName; set => itemName = value; }
        public double KnapWeight { get => knapWeight; set => knapWeight = value; }
        

        public MainForm()
        {
            InitializeComponent();
            //Result_GV.Visible = false;
            dataGrid.Visible = false;
            Calculate_Btn.ForeColor = Color.White;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan100, Primary.Teal400, Primary.LightBlue200, Accent.Blue200, TextShade.BLACK);
            // form.StartPosition = FormStartPosition.CenterScreen;
            KnapsackWeght_Lbl.Text = KnapWeight.ToString() + " Kg.";
        }
        private void Calculate_Btn_Click(object sender, EventArgs e)
        {
            
            // Create an instance of Form1
            /*MainForm form1 = new MainForm();

            // Get the data from Form1
            DataTable data = form1.Data;*/

            // Create an instance of Form2 and pass the data as an argument
            //Form5 form2 = new Form5(dataGrid);

            //form2.dataGridView.DataSource = dataGrid.DataSource;
            //form2.dataGriview = dataGridView1;
            //form2.dataGridView.Refresh();
            //form2.ShowDialog();
        }

        public void CalculateData()
        {
            // Calculate the data and store it in the "data" field
            dataGrid.Rows.Clear();
            ShowCart_Btn.Visible = true;
            dataGrid.Refresh();
            dataGrid.ColumnCount = 8;
            dataGrid.Columns[0].Name = "Items Name";
            dataGrid.Columns[1].Name = "Items Weights";
            dataGrid.Columns[2].Name = "Items Benifits";
            dataGrid.Columns[3].Name = "Items Ratio";
            dataGrid.Columns[4].Name = "Selected Weight";
            dataGrid.Columns[5].Name = "Selected Benifit";
            dataGrid.Columns[6].Name = "Select Weight %";
            dataGrid.Columns[7].Name = "Select Benifit %";
            getcall();
            dataGrid.ClearSelection();
        }

        
        public void getcall() 
        {
            try
            {
                items = ItemName_TB.Text;
                ItemName = items.Split(',').ToArray();
                itemWeight = ItemWeight_TB.Text;
                weight = itemWeight.Split(',').Select(Double.Parse).ToArray();
                itemValue = (ItemValue_TB.Text);
                benefit = itemValue.Split(',').Select(Double.Parse).ToArray();
                len = weight.Length;
                ratio = new double[weight.Length]; //ratio determines the order in which items are entered
                //Calculating Ratio
                for (int i = 0; i < len; ++i)
                {
                    ratio[i] = benefit[i] / weight[i];
                }
                int k = 0;
                while (k < len)
                {
                    dataGrid.Rows.Add(); //if there is 3 product add three rows
                    k++;
                }
                int j = 0;
                int v = len;

                /*
                 *  Fill First 4 Columns
                 */
                while (j < v)
                {
                    dataGrid.Rows[j].Cells[0].Value = ItemName[j];
                    dataGrid.Rows[j].Cells[1].Value = weight[j].ToString();
                    dataGrid.Rows[j].Cells[2].Value = benefit[j].ToString();
                    dataGrid.Rows[j].Cells[3].Value = ratio[j].ToString();
                    j++;
                }
                fill();
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure input is correct", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void fill() //fill remaining colums
        {
            double tempWeight, tempBenefit;
            //tempWeight saves temperory weight of item which will add in array*(double[] wei)  & sum in last 
            //tempBenefit saves temperory benifit of item which will add in array*(double[] ben)  & sum in last
            selectedWei = new double[weight.Length];
            //wei save value of weights
            selectedBen = new double[weight.Length];
            //ben save value of benifits
            double cW = 0; //current weight
            double cB = 0; //current benefit 
            int index = 0;
            int[] itemarray = new int[len];   // this save which item is selected

            /**  
             *      Knapsack Algorithm
             */
            while (cW < KnapWeight)
            {
                int item = getNext();        // index of next highest ratio
                if (item == -1)
                {
                    //No items left
                    break;
                }
                itemarray[index] = (item + 1);
                index++;
                if (cW + weight[item] <= KnapWeight)
                {
                    //Add items to knapsack with their respective weights
                    tempWeight = weight[item];
                    selectedWei[item] = tempWeight;
                    tempBenefit = benefit[item];
                    selectedBen[item] = tempBenefit;
                    cW += tempWeight;
                    cB += tempBenefit;
                    //mark as used for the getNext() (ratio) function
                    ratio[item] = 0; //So that item wieght is not added repeatedly
                }
                else
                {
                    //Select part of an item and give user the indication that knapsack is full
                    tempBenefit = (ratio[item] * (KnapWeight - cW));
                    selectedBen[item] = tempBenefit;
                    tempWeight = (KnapWeight - cW);
                    selectedWei[item] = tempWeight;
                    cB += tempBenefit;
                    cW += tempWeight;
                    MessageBox.Show("Knapsack Is Full", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;  //the knapsack is full
                }
            }

            weightPercnt = new double[weight.Length];
            benifitPercnt = new double[weight.Length];

            for (int i = 0; i < len; i++)
            {
                weightPercnt[i] = (selectedWei[i] / cW) * 100;
                benifitPercnt[i] = (selectedBen[i] / cB) * 100;
            }
            for (int i = 0; i < index; i++)
            {
                if (itemarray[i] != 0)
                {
                    string[] aaa = Array.ConvertAll(itemarray, element => element.ToString()).ToArray();
                    Listbox1.Items.Add(aaa[i]).ToString();
                }
            }
            label6.Text = cB.ToString() + " Rs.";
            label7.Text = cW.ToString() + " Kg.";

            /*
             *  Fill Remaining Column
             */
            for (int i = 0; i < len; i++) 
            {
                dataGrid.Rows[i].Cells[4].Value = selectedWei[i].ToString();
                dataGrid.Rows[i].Cells[5].Value = selectedBen[i].ToString();
                dataGrid.Rows[i].Cells[7].Value = benifitPercnt[i].ToString();
                dataGrid.Rows[i].Cells[6].Value = weightPercnt[i].ToString();
            }
        }

        public int getNext()
        {
            double highest = 0;
            int index = -1;
            for (int i = 0; i < benefit.Length; ++i) //Get the highest ratio item 
            {
                if (ratio[i] > highest) // Highest ratio/valued item will go in first
                {
                    highest = ratio[i];
                    index = i;
                }
            }
            return index;  //Return the index of the most valued item
        }
        private void HowToUse_Lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm ob = new AboutForm();
            ob.ShowDialog();
        }

        private void ItemWeight_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowCart_Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            form = new MainForm();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Btn_Click_1(object sender, EventArgs e)
        {
            if (ItemName_TB.Text != "" && ItemValue_TB.Text != "" && ItemWeight_TB.Text != "")
            {
                CalculateData();
                //inForm form = new MainForm();
                this.Size = new Size(850, 590);
                dataGrid.Visible = true;
            }
            else
            {
                MessageBox.Show("Enter Values First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowCart_Btn_Click_1(object sender, EventArgs e)
        {
            if (ItemName != null && weightPercnt != null && benifitPercnt != null)
            {
                ChartForm obj = new ChartForm(ItemName, weightPercnt, benifitPercnt);
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Sure To Input Values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
