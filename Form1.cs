using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation_Robot_arm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled= false;
            panel3.Enabled= false;
            panel2.Enabled= false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM5";
            try {
                serialPort1.Open();
                serialPort1.Write("Q");//Đưa về Home
                //string data = serialPort1.ReadExisting();
                label5.Text = "Da ket noi";
                label5.ForeColor = System.Drawing.Color.Green;
                groupBox1.Enabled = true;
                panel3.Enabled = true;
                panel2.Enabled = true;
                timer1.Enabled = true;
                textBox1.Text = 80.ToString();
                textBox2.Text = 80.ToString();
                textBox3.Text = 110.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                

        }

        private void button13_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            label5.Text = "Chưa kết nối";
            label5.ForeColor = System.Drawing.Color.Red;
            groupBox1.Enabled = false;
            panel3.Enabled = false;
            panel2.Enabled =false;
            textBox1.Text = 0.ToString();
            textBox2.Text = 0.ToString();
            textBox3.Text = 0.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("O");
            string Data = serialPort1.ReadExisting();
            label17.Text = Data;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //byte[] chr = new byte[] { "M" };
            //serialPort1.Write(chr, 0, 1);
            
           serialPort1.WriteLine("M");
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //byte[] chr = new byte[] { "N" };
            //serialPort1.Write(chr, 0, 1);
            serialPort1.WriteLine("N");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("K");
            if (int.Parse(textBox3.Text) < 180)
            {
                textBox3.Text = (int.Parse(textBox3.Text) + 4).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("L");
            if (int.Parse(textBox3.Text) > 70)
            {
                textBox3.Text = (int.Parse(textBox3.Text) - 4).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("H");
            if (int.Parse(textBox2.Text) < 180)
            {
                textBox2.Text = (int.Parse(textBox2.Text) + 4).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("I");
            if (int.Parse(textBox2.Text) >40)
            {
                textBox2.Text = (int.Parse(textBox2.Text) - 4).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("F");
            if (int.Parse(textBox1.Text) < 180)
            {
                textBox1.Text = (int.Parse(textBox1.Text) + 4).ToString();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("G");
            if (int.Parse(textBox1.Text) > 0)
            {
                textBox1.Text = (int.Parse(textBox1.Text) - 4).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Q");
            textBox1.Text = 80.ToString();
            textBox2.Text = 80.ToString();
            textBox3.Text = 110.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("P");
        }
    }
}
