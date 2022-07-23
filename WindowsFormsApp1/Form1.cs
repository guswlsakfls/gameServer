using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string plusStr = box_textEcho.Text;
            box_log.Items.Add(plusStr);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void btn_removeLog_Click(object sender, EventArgs e)
        {
            box_log.Items.Remove(box_log.SelectedItem);
        }
        private void lbox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_log.SelectedIndex == -1)
            {
                btn_removeLog.Enabled = false;
                netStatus.Text = "선택 항목이 없습니다.";
                return;
            }
            btn_removeLog.Enabled = true;
            netStatus.Text = box_log.SelectedItem.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
