using Guna.UI.WinForms;
using System.Drawing;

namespace masar_test
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.side_bar = new System.Windows.Forms.Panel();
            this.setting_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.setting_icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.setting_label = new Guna.UI.WinForms.GunaLabel();
            this.logout_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.logout_icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logout_label = new Guna.UI.WinForms.GunaLabel();
            this.project_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.project_icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.project_label = new Guna.UI.WinForms.GunaLabel();
            this.category_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.category_icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.category_label = new Guna.UI.WinForms.GunaLabel();
            this.home_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.home_icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.home_label = new Guna.UI.WinForms.GunaLabel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.side_bar.SuspendLayout();
            this.setting_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_icon)).BeginInit();
            this.logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_icon)).BeginInit();
            this.project_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project_icon)).BeginInit();
            this.category_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_icon)).BeginInit();
            this.home_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // side_bar
            // 
            this.side_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.side_bar.Controls.Add(this.setting_panel);
            this.side_bar.Controls.Add(this.logout_panel);
            this.side_bar.Controls.Add(this.project_panel);
            this.side_bar.Controls.Add(this.category_panel);
            this.side_bar.Controls.Add(this.home_panel);
            this.side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_bar.Location = new System.Drawing.Point(0, 0);
            this.side_bar.Name = "side_bar";
            this.side_bar.Size = new System.Drawing.Size(200, 640);
            this.side_bar.TabIndex = 0;
            // 
            // setting_panel
            // 
            this.setting_panel.Controls.Add(this.setting_icon);
            this.setting_panel.Controls.Add(this.setting_label);
            this.setting_panel.Location = new System.Drawing.Point(0, 460);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.ShadowDecoration.Parent = this.setting_panel;
            this.setting_panel.Size = new System.Drawing.Size(200, 50);
            this.setting_panel.TabIndex = 4;
            // 
            // setting_icon
            // 
            this.setting_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting_icon.Image = global::masar_test.Properties.Resources.setting;
            this.setting_icon.Location = new System.Drawing.Point(22, 6);
            this.setting_icon.Name = "setting_icon";
            this.setting_icon.ShadowDecoration.Parent = this.setting_icon;
            this.setting_icon.Size = new System.Drawing.Size(48, 38);
            this.setting_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.setting_icon.TabIndex = 4;
            this.setting_icon.TabStop = false;
            // 
            // setting_label
            // 
            this.setting_label.AutoSize = true;
            this.setting_label.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_label.ForeColor = System.Drawing.Color.White;
            this.setting_label.Location = new System.Drawing.Point(80, 10);
            this.setting_label.Name = "setting_label";
            this.setting_label.Size = new System.Drawing.Size(89, 31);
            this.setting_label.TabIndex = 3;
            this.setting_label.Text = "Setting";
            // 
            // logout_panel
            // 
            this.logout_panel.Controls.Add(this.logout_icon);
            this.logout_panel.Controls.Add(this.logout_label);
            this.logout_panel.Location = new System.Drawing.Point(0, 560);
            this.logout_panel.Name = "logout_panel";
            this.logout_panel.ShadowDecoration.Parent = this.logout_panel;
            this.logout_panel.Size = new System.Drawing.Size(200, 50);
            this.logout_panel.TabIndex = 3;
            // 
            // logout_icon
            // 
            this.logout_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout_icon.Image = global::masar_test.Properties.Resources.logout;
            this.logout_icon.Location = new System.Drawing.Point(22, 6);
            this.logout_icon.Name = "logout_icon";
            this.logout_icon.ShadowDecoration.Parent = this.logout_icon;
            this.logout_icon.Size = new System.Drawing.Size(48, 38);
            this.logout_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout_icon.TabIndex = 4;
            this.logout_icon.TabStop = false;
            // 
            // logout_label
            // 
            this.logout_label.AutoSize = true;
            this.logout_label.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_label.ForeColor = System.Drawing.Color.White;
            this.logout_label.Location = new System.Drawing.Point(80, 10);
            this.logout_label.Name = "logout_label";
            this.logout_label.Size = new System.Drawing.Size(100, 31);
            this.logout_label.TabIndex = 3;
            this.logout_label.Text = "Log Out";
            // 
            // project_panel
            // 
            this.project_panel.Controls.Add(this.project_icon);
            this.project_panel.Controls.Add(this.project_label);
            this.project_panel.Location = new System.Drawing.Point(0, 230);
            this.project_panel.Name = "project_panel";
            this.project_panel.ShadowDecoration.Parent = this.project_panel;
            this.project_panel.Size = new System.Drawing.Size(200, 50);
            this.project_panel.TabIndex = 2;
            this.project_panel.MouseEnter += new System.EventHandler(this.project_panel_enter);
            this.project_panel.MouseLeave += new System.EventHandler(this.project_panel_leave);
            // 
            // project_icon
            // 
            this.project_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.project_icon.Image = global::masar_test.Properties.Resources.project_management;
            this.project_icon.Location = new System.Drawing.Point(22, 0);
            this.project_icon.Name = "project_icon";
            this.project_icon.ShadowDecoration.Parent = this.project_icon;
            this.project_icon.Size = new System.Drawing.Size(48, 50);
            this.project_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.project_icon.TabIndex = 3;
            this.project_icon.TabStop = false;
            this.project_icon.MouseEnter += new System.EventHandler(this.project_panel_enter);
            this.project_icon.MouseLeave += new System.EventHandler(this.project_icon_leave);
            // 
            // project_label
            // 
            this.project_label.AutoSize = true;
            this.project_label.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_label.ForeColor = System.Drawing.Color.White;
            this.project_label.Location = new System.Drawing.Point(80, 10);
            this.project_label.Name = "project_label";
            this.project_label.Size = new System.Drawing.Size(101, 31);
            this.project_label.TabIndex = 2;
            this.project_label.Text = "Projects";
            this.project_label.MouseEnter += new System.EventHandler(this.project_panel_enter);
            // 
            // category_panel
            // 
            this.category_panel.Controls.Add(this.category_icon);
            this.category_panel.Controls.Add(this.category_label);
            this.category_panel.Location = new System.Drawing.Point(0, 130);
            this.category_panel.Name = "category_panel";
            this.category_panel.ShadowDecoration.Parent = this.category_panel;
            this.category_panel.Size = new System.Drawing.Size(200, 50);
            this.category_panel.TabIndex = 1;
            this.category_panel.MouseEnter += new System.EventHandler(this.category_panel_enter);
            this.category_panel.MouseLeave += new System.EventHandler(this.category_panel_leave);
            // 
            // category_icon
            // 
            this.category_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.category_icon.Image = global::masar_test.Properties.Resources.category;
            this.category_icon.Location = new System.Drawing.Point(22, 0);
            this.category_icon.Name = "category_icon";
            this.category_icon.ShadowDecoration.Parent = this.category_icon;
            this.category_icon.Size = new System.Drawing.Size(48, 50);
            this.category_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.category_icon.TabIndex = 2;
            this.category_icon.TabStop = false;
            this.category_icon.MouseEnter += new System.EventHandler(this.category_panel_enter);
            this.category_icon.MouseLeave += new System.EventHandler(this.category_icon_leave);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.ForeColor = System.Drawing.Color.White;
            this.category_label.Location = new System.Drawing.Point(80, 10);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(110, 31);
            this.category_label.TabIndex = 1;
            this.category_label.Text = "Category";
            this.category_label.MouseEnter += new System.EventHandler(this.category_panel_enter);
            // 
            // home_panel
            // 
            this.home_panel.Controls.Add(this.home_icon);
            this.home_panel.Controls.Add(this.home_label);
            this.home_panel.Location = new System.Drawing.Point(0, 30);
            this.home_panel.Name = "home_panel";
            this.home_panel.ShadowDecoration.Parent = this.home_panel;
            this.home_panel.Size = new System.Drawing.Size(200, 50);
            this.home_panel.TabIndex = 0;
            this.home_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.home_panel_Paint);
            this.home_panel.MouseEnter += new System.EventHandler(this.home_panel_enter);
            this.home_panel.MouseLeave += new System.EventHandler(this.home_panel_leave);
            // 
            // home_icon
            // 
            this.home_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_icon.Image = global::masar_test.Properties.Resources.home;
            this.home_icon.Location = new System.Drawing.Point(22, 0);
            this.home_icon.Name = "home_icon";
            this.home_icon.ShadowDecoration.Parent = this.home_icon;
            this.home_icon.Size = new System.Drawing.Size(48, 50);
            this.home_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_icon.TabIndex = 1;
            this.home_icon.TabStop = false;
            this.home_icon.MouseEnter += new System.EventHandler(this.home_panel_enter);
            this.home_icon.MouseLeave += new System.EventHandler(this.home_icon_leave);
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.ForeColor = System.Drawing.Color.White;
            this.home_label.Location = new System.Drawing.Point(80, 11);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(76, 31);
            this.home_label.TabIndex = 0;
            this.home_label.Text = "Home";
            this.home_label.Click += new System.EventHandler(this.gunaLabel1_Click);
            this.home_label.MouseEnter += new System.EventHandler(this.home_panel_enter);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            this.guna2Elipse2.TargetControl = this.project_panel;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 8;
            this.guna2Elipse3.TargetControl = this.category_panel;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 8;
            this.guna2Elipse4.TargetControl = this.home_panel;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 8;
            this.guna2Elipse5.TargetControl = this.setting_panel;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 8;
            this.guna2Elipse6.TargetControl = this.logout_panel;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 640);
            this.Controls.Add(this.side_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.side_bar.ResumeLayout(false);
            this.setting_panel.ResumeLayout(false);
            this.setting_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_icon)).EndInit();
            this.logout_panel.ResumeLayout(false);
            this.logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout_icon)).EndInit();
            this.project_panel.ResumeLayout(false);
            this.project_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project_icon)).EndInit();
            this.category_panel.ResumeLayout(false);
            this.category_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_icon)).EndInit();
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel side_bar;
        private Guna.UI2.WinForms.Guna2Panel home_panel;
        private Guna.UI2.WinForms.Guna2Panel setting_panel;
        private Guna.UI2.WinForms.Guna2Panel logout_panel;
        private Guna.UI2.WinForms.Guna2Panel project_panel;
        private Guna.UI2.WinForms.Guna2Panel category_panel;
        private Guna.UI.WinForms.GunaLabel home_label;
        private Guna.UI.WinForms.GunaLabel category_label;
        private Guna.UI.WinForms.GunaLabel setting_label;
        private Guna.UI.WinForms.GunaLabel logout_label;
        private Guna.UI.WinForms.GunaLabel project_label;
        private Guna.UI2.WinForms.Guna2PictureBox home_icon;
        private Guna.UI2.WinForms.Guna2PictureBox project_icon;
        private Guna.UI2.WinForms.Guna2PictureBox category_icon;
        private Guna.UI2.WinForms.Guna2PictureBox setting_icon;
        private Guna.UI2.WinForms.Guna2PictureBox logout_icon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
    }
}