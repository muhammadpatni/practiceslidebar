namespace practiceslidebar
{
    partial class adminoutofstock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelfullinventory = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btneset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.combosort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.inventoryoutofstock = new System.Windows.Forms.DataGridView();
            this.panelfullinventory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryoutofstock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelfullinventory
            // 
            this.panelfullinventory.BackColor = System.Drawing.Color.White;
            this.panelfullinventory.Controls.Add(this.inventoryoutofstock);
            this.panelfullinventory.Controls.Add(this.panel2);
            this.panelfullinventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfullinventory.Location = new System.Drawing.Point(0, 0);
            this.panelfullinventory.Name = "panelfullinventory";
            this.panelfullinventory.Size = new System.Drawing.Size(1047, 541);
            this.panelfullinventory.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btneset);
            this.panel2.Controls.Add(this.combosort);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 70);
            this.panel2.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 7);
            this.panel3.TabIndex = 61;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1047, 7);
            this.panel6.TabIndex = 62;
            // 
            // btneset
            // 
            this.btneset.AutoRoundedCorners = true;
            this.btneset.BackColor = System.Drawing.Color.Transparent;
            this.btneset.BorderRadius = 19;
            this.btneset.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btneset.CustomBorderColor = System.Drawing.Color.Black;
            this.btneset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneset.FillColor = System.Drawing.Color.Black;
            this.btneset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btneset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btneset.ForeColor = System.Drawing.Color.White;
            this.btneset.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btneset.Location = new System.Drawing.Point(841, 12);
            this.btneset.Name = "btneset";
            this.btneset.Size = new System.Drawing.Size(115, 40);
            this.btneset.TabIndex = 55;
            this.btneset.Text = "Reset";
            this.btneset.Click += new System.EventHandler(this.btneset_Click);
            // 
            // combosort
            // 
            this.combosort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.combosort.BackColor = System.Drawing.Color.White;
            this.combosort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combosort.BorderRadius = 15;
            this.combosort.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.combosort.BorderThickness = 3;
            this.combosort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combosort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combosort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combosort.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.combosort.ForeColor = System.Drawing.Color.Black;
            this.combosort.ItemHeight = 30;
            this.combosort.Items.AddRange(new object[] {
            "tablet",
            "capsule",
            "syrup",
            "injections",
            "creams",
            "lotions",
            "suspension",
            "gels",
            "powders",
            "drops",
            "nebulizers",
            "Suppositories",
            "Transdermal Patches",
            "Lozenges"});
            this.combosort.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.combosort.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosort.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.combosort.Location = new System.Drawing.Point(594, 15);
            this.combosort.Name = "combosort";
            this.combosort.Size = new System.Drawing.Size(220, 36);
            this.combosort.TabIndex = 36;
            this.combosort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.combosort.SelectedIndexChanged += new System.EventHandler(this.combosort_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label14.Location = new System.Drawing.Point(479, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 26);
            this.label14.TabIndex = 35;
            this.label14.Text = "Category";
            // 
            // search
            // 
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.search.BorderRadius = 16;
            this.search.BorderThickness = 3;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.search.Location = new System.Drawing.Point(170, 14);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderText = "";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(277, 39);
            this.search.TabIndex = 34;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label15.Location = new System.Drawing.Point(84, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 26);
            this.label15.TabIndex = 33;
            this.label15.Text = "Search";
            // 
            // inventoryoutofstock
            // 
            this.inventoryoutofstock.AllowUserToAddRows = false;
            this.inventoryoutofstock.AllowUserToDeleteRows = false;
            this.inventoryoutofstock.BackgroundColor = System.Drawing.Color.White;
            this.inventoryoutofstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryoutofstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryoutofstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryoutofstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryoutofstock.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventoryoutofstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryoutofstock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.inventoryoutofstock.Location = new System.Drawing.Point(0, 0);
            this.inventoryoutofstock.Margin = new System.Windows.Forms.Padding(10);
            this.inventoryoutofstock.MultiSelect = false;
            this.inventoryoutofstock.Name = "inventoryoutofstock";
            this.inventoryoutofstock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryoutofstock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventoryoutofstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryoutofstock.Size = new System.Drawing.Size(1047, 471);
            this.inventoryoutofstock.TabIndex = 60;
            // 
            // adminoutofstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.Controls.Add(this.panelfullinventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminoutofstock";
            this.Text = "adminoutofstock";
            this.Load += new System.EventHandler(this.adminoutofstock_Load);
            this.panelfullinventory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryoutofstock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelfullinventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2GradientButton btneset;
        private Guna.UI2.WinForms.Guna2ComboBox combosort;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView inventoryoutofstock;
    }
}