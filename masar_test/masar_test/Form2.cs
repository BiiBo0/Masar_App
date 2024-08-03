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
        private Timer moveTimer;
        private int moveSpeed = 1;

        public Dashboard()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void home_panel_leave(object sender, EventArgs e)
        {
            this.home_panel.BackColor = Color.FromArgb(170, 199, 216);
            this.home_label.ForeColor = Color.White;
             this.home_icon.Image = global::masar_test.Properties.Resources.home;
            //this.home_icon.Visible = true;

        }

        private void home_panel_enter(object sender, EventArgs e)
        {
            this.home_panel.BackColor = Color.FromArgb(255, 255, 255);
            this.home_label.ForeColor = Color.Black;
            this.home_icon.Image = global::masar_test.Properties.Resources.home_black;
            //this.home_icon.Visible = false;

        }

        private void category_panel_enter(object sender, EventArgs e)
        {
            this.category_panel.BackColor = Color.FromArgb(255, 255, 255);
            this.category_label.ForeColor = Color.Black;
            this.category_icon.Image = global::masar_test.Properties.Resources.category_black;

        }

        private void category_panel_leave(object sender, EventArgs e)
        {
            this.category_panel.BackColor = Color.FromArgb(170, 199, 216);
            this.category_label.ForeColor = Color.White;
            this.category_icon.Image = global::masar_test.Properties.Resources.category;

        }

        private void category_panel_MouseClick(object sender, MouseEventArgs e)
        {
            moveTimer = new Timer();
            moveTimer.Interval = 100;

            if (category_panel.Top != 30)
            {
                moveTimer.Tick += MovePanelUp;
                moveTimer.Start();
                home_panel.Visible = false;
                project_panel.Visible = false;
            }
            else
            {
                moveTimer.Tick += MovePanelDown;
                moveTimer.Start();
                home_panel.Visible = true;
                project_panel.Visible = true;
            }
            this.treeView.Visible = !this.treeView.Visible;

        }

        private void project_panel_enter(object sender, EventArgs e)
        {
            this.project_panel.BackColor = Color.FromArgb(255, 255, 255);
            this.project_label.ForeColor = Color.Black;
            this.project_icon.Image = global::masar_test.Properties.Resources.project_management_black;

        }

        private void project_panel_leave(object sender, EventArgs e)
        {
            this.project_panel.BackColor = Color.FromArgb(170, 199, 216);
            this.project_label.ForeColor = Color.White;
            this.project_icon.Image = global::masar_test.Properties.Resources.project_management;

        }

        private void setting_panel_enter(object sender, EventArgs e)
        {
            this.setting_panel.BackColor = Color.FromArgb(255,255,255);
            this.setting_label.ForeColor = Color.Black;
            this.setting_icon.Image = global::masar_test.Properties.Resources.setting_black;

        }

        private void setting_panel_leave(object sender, EventArgs e)
        {
            this.setting_panel.BackColor = Color.FromArgb(170, 199, 216);
            this.setting_label.ForeColor = Color.White;
            this.setting_icon.Image = global::masar_test.Properties.Resources.setting;
        }

        private void logout_panel_enter(object sender, EventArgs e)
        {
            this.logout_panel.BackColor = Color.FromArgb(255, 255, 255);
            this.logout_label.ForeColor = Color.Black;
            this.logout_icon.Image = global::masar_test.Properties.Resources.logout_black;

        }

        private void logout_panel_leave(object sender, EventArgs e)
        {
            this.logout_panel.BackColor = Color.FromArgb(170, 199, 216);
            this.logout_label.ForeColor = Color.White;
            this.logout_icon.Image = global::masar_test.Properties.Resources.logout;
        }

        private void MovePanelUp(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                category_panel.Top -= moveSpeed;
            }

            // Check for panel boundaries to prevent going out of form
            if (category_panel.Top >= this.side_bar.Top + 20)
            {
                moveTimer.Stop();
            }
        }

        private void MovePanelDown(object sender, EventArgs e )
        {
            for (int i = 0; i < 100; i++)
            {
                category_panel.Top += moveSpeed;
            }
            moveTimer.Stop();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
