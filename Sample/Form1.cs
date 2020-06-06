using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = comboBox3.SelectedItem.ToString();
            if (curItem == "Load First Set")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
            }
            else if (curItem == "Load Second Set")
            {
                comboBox5.Visible = true;
                comboBox6.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Visible = true;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string curItem = comboBox3.SelectedItem.ToString();
                if (curItem == "Load First Set")
                {
                    MessageBox.Show("Selected Environment: " + comboBox1.SelectedItem.ToString() + "  \n" + "Selected Location: " + comboBox2.SelectedItem.ToString());
                }
                else if (curItem == "Load Second Set")
                {

                    MessageBox.Show("Selected Environment: "+comboBox5.SelectedItem.ToString()+"  \n"+ "Selected Location: "+comboBox6.SelectedItem.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please select the values from the drop down above");
            }
        }
    }
}
