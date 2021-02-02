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
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào " + txtTen.Text);
            lblDepTrai.Text = txtTen.Text + " có đẹp trai không?";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                double s = so1 - so2;
                lblKetQua.Text = "Thương = " + s;
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu");
                txtSo1.Text = "";
                txtSo2.Text = "";
                txtSo1.Focus();
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                double s = so1 * so2;
                lblKetQua.Text = "Tích = " + s;
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu");
                txtSo1.Text = "";
                txtSo2.Text = "";
                txtSo1.Focus();
            }
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                double s = so1 + so2;
                lblKetQua.Text = "Tổng = " + s;
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu");
                txtSo1.Text = "";
                txtSo2.Text = "";
                txtSo1.Focus();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                double s = so1 - so2;
                lblKetQua.Text = "Hiệu = " + s;
            } 
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu");
                txtSo1.Text = "";
                txtSo2.Text = "";
                txtSo1.Focus();
            }
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnMoForm_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
