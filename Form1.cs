using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DateTime start;
        public Form1()
        {
            InitializeComponent();
            start = DateTime.Now;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Concept 1
        private void button1_Click(object sender, EventArgs e)
        {
            string s0 = "this ";
            string s1 = "is ";
            string s2 = "a ";
            string s3 = "concatenated ";
            string s4 = "string!";
            MessageBox.Show(s0 + s1 + s2 + s3 + s4, "Concept 1", MessageBoxButtons.OK);
        }

        //Concept 2
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            double elapsed = Math.Round((now - start).TotalSeconds, 2);
            MessageBox.Show("It's been " + elapsed.ToString() + " seconds since you opened this program.", "Concept 2"); 
        }

        //Concept 3
        private void button3_Click(object sender, EventArgs e)
        {
            String nan = "notAnumber";
            int intvalue;
            try
            {
                intvalue = int.Parse(nan);

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Concept 3");
            }

        }

        //Concept 4 -- Arrays
        private void button4_Click(object sender, EventArgs e)
        {
            string[] arr = { "1", "2", "3", "4", "16"};
            MessageBox.Show("The length of this array is " + arr.Length + 
                " and the content ranges from " + arr[0] + " to " + arr[arr.Length-1]);

        }

        //Concept 5 -- Events
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if((checkBox1.Checked && !checkBox2.Checked) || (!checkBox1.Checked && checkBox2.Checked))
            {
                label3.Text = "true";
            }
            else
            {
                label3.Text = "false";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked && !checkBox2.Checked) || (!checkBox1.Checked && checkBox2.Checked))
            {
                label3.Text = "true";
            }
            else
            {
                label3.Text = "false";
            }
        }
    }
}
