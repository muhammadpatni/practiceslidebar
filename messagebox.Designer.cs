namespace practiceslidebar
{
    partial class messagebox
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tittle = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.ok = new Guna.UI2.WinForms.Guna2TileButton();
            this.messagepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.messagepic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 153);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(323, 11);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.Color.White;
            this.tittle.Location = new System.Drawing.Point(8, 5);
            this.tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(46, 18);
            this.tittle.TabIndex = 1;
            this.tittle.Text = "label1";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(109, 56);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(200, 18);
            this.message.TabIndex = 2;
            this.message.Text = "Manufacturer Is Required";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ok.FillColor = System.Drawing.Color.White;
            this.ok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ok.Location = new System.Drawing.Point(112, 103);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ok.Name = "ok";
            this.ok.PressedColor = System.Drawing.Color.Transparent;
            this.ok.Size = new System.Drawing.Size(118, 33);
            this.ok.TabIndex = 3;
            this.ok.Text = "OKAY";
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // messagepic
            // 
            this.messagepic.Image = global::practiceslidebar.Properties.Resources.close;
            this.messagepic.Location = new System.Drawing.Point(39, 43);
            this.messagepic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.messagepic.Name = "messagepic";
            this.messagepic.Size = new System.Drawing.Size(60, 60);
            this.messagepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.messagepic.TabIndex = 4;
            this.messagepic.TabStop = false;
            this.messagepic.Click += new System.EventHandler(this.messagepic_Click);
            // 
            // messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(323, 164);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.messagepic);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.message);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "messagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "messagebox";
            this.Load += new System.EventHandler(this.messagebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messagepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TileButton ok;
        public System.Windows.Forms.Label tittle;
        public System.Windows.Forms.Label message;
        public System.Windows.Forms.PictureBox messagepic;
    }
}