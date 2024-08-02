namespace masar_test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.email_text = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBox2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.eye = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.fp_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.fp_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BorderRadius = 12;
            this.login_button.CheckedState.Parent = this.login_button;
            this.login_button.CustomImages.Parent = this.login_button;
            this.login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.login_button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.login_button.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.Parent = this.login_button;
            this.login_button.Location = new System.Drawing.Point(355, 564);
            this.login_button.Name = "login_button";
            this.login_button.ShadowDecoration.Parent = this.login_button;
            this.login_button.Size = new System.Drawing.Size(303, 45);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "log in";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.gunaLabel1.Location = new System.Drawing.Point(437, 217);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 48);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Log In";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // email_text
            // 
            this.email_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.email_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_text.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.email_text.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.email_text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.email_text.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.email_text.Location = new System.Drawing.Point(355, 327);
            this.email_text.Name = "email_text";
            this.email_text.PasswordChar = '\0';
            this.email_text.SelectedText = "";
            this.email_text.Size = new System.Drawing.Size(303, 34);
            this.email_text.TabIndex = 6;
            this.email_text.Text = "Email";
            // 
            // gunaLineTextBox2
            // 
            this.gunaLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.gunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.gunaLineTextBox2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLineTextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLineTextBox2.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLineTextBox2.Location = new System.Drawing.Point(355, 412);
            this.gunaLineTextBox2.Name = "gunaLineTextBox2";
            this.gunaLineTextBox2.PasswordChar = '\0';
            this.gunaLineTextBox2.SelectedText = "";
            this.gunaLineTextBox2.Size = new System.Drawing.Size(303, 34);
            this.gunaLineTextBox2.TabIndex = 7;
            this.gunaLineTextBox2.Text = "Password";
            this.gunaLineTextBox2.TextChanged += new System.EventHandler(this.gunaLineTextBox2_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-4, -3);
            this.guna2PictureBox1.MinimumSize = new System.Drawing.Size(1357, 862);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1357, 862);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // eye
            // 
            this.eye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.eye.BackgroundImage = global::masar_test.Properties.Resources.eye;
            this.eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eye.Location = new System.Drawing.Point(630, 412);
            this.eye.Name = "eye";
            this.eye.ShadowDecoration.Parent = this.eye;
            this.eye.Size = new System.Drawing.Size(28, 22);
            this.eye.TabIndex = 8;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            this.eye.DoubleClick += new System.EventHandler(this.eye_Click);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.gunaLinkLabel1.DisabledLinkColor = System.Drawing.Color.Fuchsia;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.gunaLinkLabel1.Location = new System.Drawing.Point(351, 482);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(180, 24);
            this.gunaLinkLabel1.TabIndex = 9;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Forget Password ?";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // fp_panel
            // 
            this.fp_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.fp_panel.Controls.Add(this.guna2GradientButton2);
            this.fp_panel.Controls.Add(this.gunaLabel2);
            this.fp_panel.Controls.Add(this.label1);
            this.fp_panel.Controls.Add(this.gunaLineTextBox1);
            this.fp_panel.Controls.Add(this.guna2GradientButton1);
            this.fp_panel.Location = new System.Drawing.Point(355, 217);
            this.fp_panel.Name = "fp_panel";
            this.fp_panel.ShadowDecoration.Parent = this.fp_panel;
            this.fp_panel.Size = new System.Drawing.Size(303, 492);
            this.fp_panel.TabIndex = 10;
            this.fp_panel.Visible = false;
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLineTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLineTextBox1.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(3, 110);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(303, 34);
            this.gunaLineTextBox1.TabIndex = 8;
            this.gunaLineTextBox1.Text = "Email";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 12;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(3, 347);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(303, 45);
            this.guna2GradientButton1.TabIndex = 7;
            this.guna2GradientButton1.Text = "Back";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Find your account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial Black", 7F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.gunaLabel2.Location = new System.Drawing.Point(5, 48);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(174, 17);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "Enter your email address.";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click_1);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 12;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(107)))), ((int)(((byte)(122)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(3, 265);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(303, 45);
            this.guna2GradientButton2.TabIndex = 11;
            this.guna2GradientButton2.Text = "Continue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 820);
            this.Controls.Add(this.fp_panel);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.gunaLineTextBox2);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1350, 820);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.fp_panel.ResumeLayout(false);
            this.fp_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton login_button;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox email_text;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel eye;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI2.WinForms.Guna2Panel fp_panel;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}

