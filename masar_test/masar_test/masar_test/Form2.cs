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
    public partial class Dashboard : Form
    {
        bool in_home_panel = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void home_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void home_icon_leave(object sender, EventArgs e)
        {
                this.home_panel.BackColor = Color.FromArgb(170, 199, 216);         
        }


        private void home_panel_leave(object sender, EventArgs e)
        {
            this.home_panel.BackColor = Color.FromArgb(170, 199, 216);
            in_home_panel=false;
        }

        private void home_panel_enter(object sender, EventArgs e)
        {
            this.home_panel.BackColor = Color.FromArgb(84, 107, 122);
            in_home_panel=true;
        }

        private void category_panel_enter(object sender, EventArgs e)
        {
            this.category_panel.BackColor = Color.FromArgb(84, 107, 122);
        }

        private void category_panel_leave(object sender, EventArgs e)
        {
            this.category_panel.BackColor = Color.FromArgb(170, 199, 216);
        }
        private void category_icon_leave(object sender, EventArgs e)
        {
            this.category_panel.BackColor = Color.FromArgb(170, 199, 216);
        }

        private void project_panel_enter(object sender, EventArgs e)
        {
          //  this.project_panel.BorderRadius = 100;
            this.project_panel.BackColor = Color.FromArgb(84, 107, 122);

        }

        private void project_panel_leave(object sender, EventArgs e)
        {
            this.project_panel.BackColor = Color.FromArgb(170, 199, 216);
        }

        private void project_icon_leave(object sender, EventArgs e)
        {
            this.project_panel.BackColor = Color.FromArgb(170, 199, 216);
        }

    }
}
