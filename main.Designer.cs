namespace practiceslidebar
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnhome = new Guna.UI.WinForms.GunaButton();
            this.btnhelp = new Guna.UI.WinForms.GunaButton();
            this.btnabout = new Guna.UI.WinForms.GunaButton();
            this.btnsetting = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.slidebartimer = new System.Windows.Forms.Timer(this.components);
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.paneluper = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.panelmain = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.slidebar.SuspendLayout();
            this.paneluper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnhome);
            this.panel3.Controls.Add(this.btnhelp);
            this.panel3.Controls.Add(this.btnabout);
            this.panel3.Controls.Add(this.btnsetting);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 278);
            this.panel3.TabIndex = 1;
            // 
            // btnhome
            // 
            this.btnhome.AnimationHoverSpeed = 0.07F;
            this.btnhome.AnimationSpeed = 0.03F;
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnhome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnhome.BorderColor = System.Drawing.Color.Black;
            this.btnhome.CausesValidation = false;
            this.btnhome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.FocusedColor = System.Drawing.Color.Empty;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageOffsetX = 6;
            this.btnhome.ImageSize = new System.Drawing.Size(20, 20);
            this.btnhome.Location = new System.Drawing.Point(0, 0);
            this.btnhome.Name = "btnhome";
            this.btnhome.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnhome.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnhome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnhome.OnHoverImage = null;
            this.btnhome.OnPressedColor = System.Drawing.Color.Black;
            this.btnhome.Size = new System.Drawing.Size(157, 43);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "      Home";
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.AnimationHoverSpeed = 0.07F;
            this.btnhelp.AnimationSpeed = 0.03F;
            this.btnhelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnhelp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnhelp.BorderColor = System.Drawing.Color.Black;
            this.btnhelp.CausesValidation = false;
            this.btnhelp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnhelp.FocusedColor = System.Drawing.Color.Empty;
            this.btnhelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhelp.ForeColor = System.Drawing.Color.White;
            this.btnhelp.Image = ((System.Drawing.Image)(resources.GetObject("btnhelp.Image")));
            this.btnhelp.ImageOffsetX = 6;
            this.btnhelp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnhelp.Location = new System.Drawing.Point(0, 86);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnhelp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnhelp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnhelp.OnHoverImage = null;
            this.btnhelp.OnPressedColor = System.Drawing.Color.Black;
            this.btnhelp.Size = new System.Drawing.Size(157, 43);
            this.btnhelp.TabIndex = 4;
            this.btnhelp.Text = "      Help";
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnabout
            // 
            this.btnabout.AnimationHoverSpeed = 0.07F;
            this.btnabout.AnimationSpeed = 0.03F;
            this.btnabout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnabout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnabout.BorderColor = System.Drawing.Color.Black;
            this.btnabout.CausesValidation = false;
            this.btnabout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnabout.FocusedColor = System.Drawing.Color.Empty;
            this.btnabout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnabout.ForeColor = System.Drawing.Color.White;
            this.btnabout.Image = ((System.Drawing.Image)(resources.GetObject("btnabout.Image")));
            this.btnabout.ImageOffsetX = 6;
            this.btnabout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnabout.Location = new System.Drawing.Point(0, 129);
            this.btnabout.Name = "btnabout";
            this.btnabout.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnabout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnabout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnabout.OnHoverImage = null;
            this.btnabout.OnPressedColor = System.Drawing.Color.Black;
            this.btnabout.Size = new System.Drawing.Size(157, 43);
            this.btnabout.TabIndex = 2;
            this.btnabout.Text = "      About";
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.AnimationHoverSpeed = 0.07F;
            this.btnsetting.AnimationSpeed = 0.03F;
            this.btnsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnsetting.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnsetting.BorderColor = System.Drawing.Color.Black;
            this.btnsetting.CausesValidation = false;
            this.btnsetting.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsetting.FocusedColor = System.Drawing.Color.Empty;
            this.btnsetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsetting.ForeColor = System.Drawing.Color.White;
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.ImageOffsetX = 6;
            this.btnsetting.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsetting.Location = new System.Drawing.Point(0, 37);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnsetting.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsetting.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsetting.OnHoverImage = null;
            this.btnsetting.OnPressedColor = System.Drawing.Color.Black;
            this.btnsetting.Size = new System.Drawing.Size(157, 43);
            this.btnsetting.TabIndex = 3;
            this.btnsetting.Text = "      Setting";
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.btnmenu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 60);
            this.panel2.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(57, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(50, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Menu";
            // 
            // btnmenu
            // 
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(9, 15);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(32, 21);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmenu.TabIndex = 0;
            this.btnmenu.TabStop = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // slidebartimer
            // 
            this.slidebartimer.Interval = 1;
            this.slidebartimer.Tick += new System.EventHandler(this.slidebar_tick);
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.slidebar.Controls.Add(this.panel2);
            this.slidebar.Controls.Add(this.panel3);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(0, 0);
            this.slidebar.MaximumSize = new System.Drawing.Size(164, 561);
            this.slidebar.MinimumSize = new System.Drawing.Size(58, 561);
            this.slidebar.Name = "slidebar";
            this.slidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.slidebar.Size = new System.Drawing.Size(164, 561);
            this.slidebar.TabIndex = 2;
            // 
            // paneluper
            // 
            this.paneluper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.paneluper.Controls.Add(this.gunaButton5);
            this.paneluper.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneluper.Location = new System.Drawing.Point(164, 0);
            this.paneluper.Name = "paneluper";
            this.paneluper.Size = new System.Drawing.Size(737, 39);
            this.paneluper.TabIndex = 3;
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.CausesValidation = false;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = null;
            this.gunaButton5.ImageOffsetX = 6;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(704, 0);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(33, 39);
            this.gunaButton5.TabIndex = 4;
            this.gunaButton5.Text = "X";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.DimGray;
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(164, 39);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(737, 522);
            this.panelmain.TabIndex = 4;
            this.panelmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmain_Paint);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 561);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.paneluper);
            this.Controls.Add(this.slidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.slidebar.ResumeLayout(false);
            this.paneluper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnhome;
        private Guna.UI.WinForms.GunaButton btnabout;
        private Guna.UI.WinForms.GunaButton btnsetting;
        private Guna.UI.WinForms.GunaButton btnhelp;
        private System.Windows.Forms.PictureBox btnmenu;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer slidebartimer;
        private System.Windows.Forms.FlowLayoutPanel slidebar;
        private Guna.UI.WinForms.GunaPanel paneluper;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private System.Windows.Forms.Panel panelmain;
    }
}

