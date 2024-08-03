using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masar_test
{
    public partial class Login_page : Form
    {
        bool flag = false;
        public Login_page()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Click(object sender, PaintEventArgs e)
        {
            
           // login_button.Visible=false;
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {

        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (!flag)
                this.eye.BackgroundImage = global::masar_test.Properties.Resources.not_eye;
            else
                this.eye.BackgroundImage = global::masar_test.Properties.Resources.eye;
            flag = !flag;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fp_panel.Visible = true;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            fp_panel.Visible = false;
        }
    }
}
