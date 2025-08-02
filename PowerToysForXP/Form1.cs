using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerToysForXP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            textBox4.Text = progressBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked!");
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && int.Parse(textBox3.Text) > 0)
            {
                MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");
                MessageBox.Show($"You are {textBox3.Text} Years Old.");

                if (checkBox1.Checked)
                {
                    MessageBox.Show("Thanks For Accepting Termas and Conditions.");
                    checkBox1.Dispose();
                    progressBar1.Value = 100;
                    
                }
                else
                {
                    MessageBox.Show("Please Accept Terms and Conditions First.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter your name.");
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

        this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Generalbtn_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
            DashBoardPanel.Visible = false;
            GeneralPanel.Visible = true;
        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
