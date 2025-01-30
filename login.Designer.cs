namespace practiceslidebar
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.paneltop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnclose = new Guna.UI.WinForms.GunaButton();
            this.panelside = new System.Windows.Forms.Panel();
            this.combouser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelmain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneltop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelside.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panelmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.paneltop.Controls.Add(this.panel3);
            this.paneltop.Controls.Add(this.btnclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(632, 58);
            this.paneltop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gunaLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 58);
            this.panel3.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(124, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(410, 44);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "patni medical store";
            // 
            // btnclose
            // 
            this.btnclose.AnimationHoverSpeed = 0.07F;
            this.btnclose.AnimationSpeed = 0.03F;
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnclose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnclose.BorderColor = System.Drawing.Color.Black;
            this.btnclose.CausesValidation = false;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FocusedColor = System.Drawing.Color.Empty;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclose.ImageOffsetX = 6;
            this.btnclose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnclose.Location = new System.Drawing.Point(599, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnclose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnclose.OnHoverImage = null;
            this.btnclose.OnPressedColor = System.Drawing.Color.Black;
            this.btnclose.Size = new System.Drawing.Size(33, 58);
            this.btnclose.TabIndex = 8;
            this.btnclose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelside.Controls.Add(this.combouser);
            this.panelside.Controls.Add(this.label2);
            this.panelside.Controls.Add(this.label4);
            this.panelside.Controls.Add(this.panel2);
            this.panelside.Controls.Add(this.panellogo);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 58);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(175, 444);
            this.panelside.TabIndex = 1;
            // 
            // combouser
            // 
            this.combouser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.combouser.BackColor = System.Drawing.Color.White;
            this.combouser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combouser.BorderThickness = 5;
            this.combouser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combouser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combouser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combouser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combouser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.combouser.ForeColor = System.Drawing.Color.Black;
            this.combouser.ItemHeight = 30;
            this.combouser.Items.AddRange(new object[] {
            "owner",
            "admin",
            "employee"});
            this.combouser.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.combouser.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combouser.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combouser.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combouser.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.combouser.Location = new System.Drawing.Point(6, 311);
            this.combouser.Name = "combouser";
            this.combouser.Size = new System.Drawing.Size(166, 36);
            this.combouser.TabIndex = 34;
            this.combouser.SelectedIndexChanged += new System.EventHandler(this.combouser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 45);
            this.label4.TabIndex = 35;
            this.label4.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 29);
            this.panel2.TabIndex = 1;
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.guna2CirclePictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(175, 171);
            this.panellogo.TabIndex = 8;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(6, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(163, 141);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelmain.Controls.Add(this.label3);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(175, 58);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(457, 444);
            this.panelmain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Please select user from user box\r\n";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(175, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 444);
            this.panel1.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.paneltop);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.paneltop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel panelmain;
        private Guna.UI.WinForms.GunaButton btnclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox combouser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}