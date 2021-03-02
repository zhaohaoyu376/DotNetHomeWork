using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = this.textBox1.Text.Trim();
            string str2 = this.textBox2.Text.Trim();
            if (str1.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            int num1 = Convert.ToInt32(str1);


            if (num1 < 0 || num1 > 1000)
            {
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            if (str2.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            int num2 = Convert.ToInt32(str2);

            if (num2 < 0 || num2 > 1000)
            {
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            this.textBox3.Text = (num1 + num2).ToString();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str1 = this.textBox1.Text.Trim();
            string str2 = this.textBox2.Text.Trim();
            if (str1.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            int num1 = Convert.ToInt32(str1);


            if (num1 < 0 || num1 > 1000)
            {
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            if (str2.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            int num2 = Convert.ToInt32(str2);

            if (num2 < 0 || num2 > 1000)
            {
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            this.textBox3.Text = (num1 * num2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = this.textBox1.Text.Trim();
            string str2 = this.textBox2.Text.Trim();
            if (str1.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            int num1 = Convert.ToInt32(str1);


            if (num1 < 0 || num1 > 1000)
            {
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            if (str2.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            int num2 = Convert.ToInt32(str2);

            if (num2 < 0 || num2 > 1000)
            {
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            this.textBox3.Text = (num1 - num2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = this.textBox1.Text.Trim();
            string str2 = this.textBox2.Text.Trim();
            if (str1.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            int num1 = Convert.ToInt32(str1);


            if (num1 < 0 || num1 > 1000)
            {
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            if (str2.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            int num2 = Convert.ToInt32(str2);

            if (num2 < 0 || num2 > 1000 || num2 ==0)
            {
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            this.textBox3.Text = (num1 / num2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str1 = this.textBox1.Text.Trim();
            string str2 = this.textBox2.Text.Trim();
            if (str1.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            int num1 = Convert.ToInt32(str1);


            if (num1 < 0 || num1 > 1000)
            {
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            if (str2.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            int num2 = Convert.ToInt32(str2);

            if (num2 < 0 || num2 > 1000 || num2==0)
            {
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            this.textBox3.Text = (num1 % num2).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str1 = this.textBox1.Text.Trim();
            string str2 = this.textBox2.Text.Trim();
            if (str1.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            int num1 = Convert.ToInt32(str1);


            if (num1 < 0 || num1 > 1000)
            {
                MessageBox.Show("第一个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
                return;
            }

            if (str2.Length == 0)
            {
                //第一种方式提示错误
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            int num2 = Convert.ToInt32(str2);

            if (num2 < 0 || num2 > 1000)
            {
                MessageBox.Show("第二个数字输入有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = string.Empty;
                this.textBox2.Focus();
                return;
            }

            num1 = Convert.ToInt32(num1);
            num2 = Convert.ToInt32(num2);


        }
    }


}

