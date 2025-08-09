using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PowerToysForXP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine("Button clicked!");
            if ( textBox1.Text.ToString().Length > 0 )
            {
                if(int.TryParse(textBox3.Text,out int age) && age > 0)
                {
                    MessageBox.Show($"Hello {textBox1.Text}");
                    MessageBox.Show($"You are {textBox3.Text} Years Old.");

                    if (checkBox1.Checked)
                    {
                        comboBox1.Items.Add(textBox4.Text);
                        MessageBox.Show("Thanks For Accepting Termas and Conditions.");
                        checkBox1.Dispose();
                        timer.Interval = 100;
                        timer.Start();
                        // Image img =  openFileDialog1.OpenFile("t.jpg");
                        //dataGridView1.Rows.Add(textBox1.Text,textBox3.Text);
                    }
                    else
                    {
                        errorTerms.SetError(checkBox1, "Please Accept Terms ans Conditions.");
                    }
              
                }
                else
                {
                    errorAge.SetError(textBox3, "Please Enter a valid Age.");
                }
            }
            else
            {
                errorTerms.SetError(textBox1, "Please Enter your First Name");
                
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width),Convert.ToInt32(0.5 * workingRectangle.Height));

            this.Location = new System.Drawing.Point(10, 10);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            submitButton.BackColor = Color.Black;
            submitButton.ForeColor = Color.White;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            submitButton.ForeColor = Color.Black;
            submitButton.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        DialogResult result = MessageBox.Show("DoYou want to close this Application?", "Closing the app", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Generalbtn_Click(object sender, EventArgs e)
        {
            //SettingsPanel.Visible = false;
            //DashBoardPanel.Visible = false;
            //GeneralPanel.Visible = true;
        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {
            //SettingsPanel.Visible = true;
            //DashBoardPanel.Visible = false;
            //GeneralPanel.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            { 
                progressBar1.Value += 1; 
            }
            else
            {
                timer.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SettingsPanel.Visible = false;
            //DashBoardPanel.Visible = true;
            //GeneralPanel.Visible = false;
        }
    }
}
