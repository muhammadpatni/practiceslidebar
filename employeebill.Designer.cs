namespace practiceslidebar
{
    partial class employeebill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeebill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtinnumber = new System.Windows.Forms.TextBox();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtquan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inventory = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billitem = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbgt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.printorder = new Guna.UI2.WinForms.Guna2Button();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discard = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billitem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discard)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // txtinnumber
            // 
            this.txtinnumber.Enabled = false;
            this.txtinnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinnumber.Location = new System.Drawing.Point(137, 31);
            this.txtinnumber.Name = "txtinnumber";
            this.txtinnumber.Size = new System.Drawing.Size(153, 22);
            this.txtinnumber.TabIndex = 1;
            this.txtinnumber.TextChanged += new System.EventHandler(this.txtinnumber_TextChanged);
            // 
            // txtcusname
            // 
            this.txtcusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusname.Location = new System.Drawing.Point(137, 123);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(153, 22);
            this.txtcusname.TabIndex = 2;
            this.txtcusname.TextChanged += new System.EventHandler(this.txtcusname_TextChanged);
            this.txtcusname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcusname_KeyDown);
            // 
            // txtcusid
            // 
            this.txtcusid.Enabled = false;
            this.txtcusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusid.Location = new System.Drawing.Point(137, 75);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(153, 22);
            this.txtcusid.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtquan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 43);
            this.panel1.TabIndex = 4;
            // 
            // btncancel
            // 
            this.btncancel.AutoRoundedCorners = true;
            this.btncancel.BorderRadius = 17;
            this.btncancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncancel.FillColor = System.Drawing.Color.White;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Red;
            this.btncancel.Location = new System.Drawing.Point(601, 3);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(113, 37);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "CancelOrder";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.InitialImage")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(550, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 22);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // txtamount
            // 
            this.txtamount.Enabled = false;
            this.txtamount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.ForeColor = System.Drawing.Color.Black;
            this.txtamount.Location = new System.Drawing.Point(467, 9);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(62, 26);
            this.txtamount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(409, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount";
            // 
            // txtquan
            // 
            this.txtquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquan.Location = new System.Drawing.Point(346, 12);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(50, 22);
            this.txtquan.TabIndex = 11;
            this.txtquan.Visible = false;
            this.txtquan.TextChanged += new System.EventHandler(this.txtquan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(312, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qty";
            this.label5.Visible = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(67, 12);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(239, 22);
            this.txtsearch.TabIndex = 9;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inventory);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(321, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 174);
            this.panel4.TabIndex = 5;
            // 
            // inventory
            // 
            this.inventory.AllowUserToAddRows = false;
            this.inventory.AllowUserToDeleteRows = false;
            this.inventory.BackgroundColor = System.Drawing.Color.White;
            this.inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.inventory.Location = new System.Drawing.Point(0, 0);
            this.inventory.Margin = new System.Windows.Forms.Padding(10);
            this.inventory.MultiSelect = false;
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventory.Size = new System.Drawing.Size(730, 131);
            this.inventory.TabIndex = 27;
            this.inventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtinnumber);
            this.panel5.Controls.Add(this.txtcusname);
            this.panel5.Controls.Add(this.txtcusid);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 174);
            this.panel5.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Invoice#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer#";
            // 
            // billitem
            // 
            this.billitem.AllowUserToAddRows = false;
            this.billitem.AllowUserToDeleteRows = false;
            this.billitem.BackgroundColor = System.Drawing.Color.White;
            this.billitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billitem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billitem.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.billitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.itemname,
            this.rate,
            this.amount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billitem.DefaultCellStyle = dataGridViewCellStyle6;
            this.billitem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.billitem.Location = new System.Drawing.Point(10, 10);
            this.billitem.Margin = new System.Windows.Forms.Padding(10);
            this.billitem.Name = "billitem";
            this.billitem.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billitem.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.billitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billitem.Size = new System.Drawing.Size(542, 280);
            this.billitem.TabIndex = 28;
            this.billitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billitem_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.billitem);
            this.panel2.Controls.Add(this.lbgt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.discard);
            this.panel2.Location = new System.Drawing.Point(12, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 307);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbgt
            // 
            this.lbgt.AutoSize = true;
            this.lbgt.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgt.ForeColor = System.Drawing.Color.White;
            this.lbgt.Location = new System.Drawing.Point(787, 125);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(20, 22);
            this.lbgt.TabIndex = 30;
            this.lbgt.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(741, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Grand Total : RS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.printorder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 75);
            this.panel3.TabIndex = 31;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnsave
            // 
            this.btnsave.BorderColor = System.Drawing.Color.White;
            this.btnsave.BorderThickness = 5;
            this.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnsave.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(292, 9);
            this.btnsave.Name = "btnsave";
            this.btnsave.PressedColor = System.Drawing.Color.Transparent;
            this.btnsave.Size = new System.Drawing.Size(244, 54);
            this.btnsave.TabIndex = 33;
            this.btnsave.Text = "Print and Save";
            this.btnsave.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // printorder
            // 
            this.printorder.BorderColor = System.Drawing.Color.White;
            this.printorder.BorderThickness = 5;
            this.printorder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printorder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.printorder.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printorder.ForeColor = System.Drawing.Color.White;
            this.printorder.Location = new System.Drawing.Point(22, 9);
            this.printorder.Name = "printorder";
            this.printorder.PressedColor = System.Drawing.Color.Transparent;
            this.printorder.Size = new System.Drawing.Size(250, 54);
            this.printorder.TabIndex = 32;
            this.printorder.Text = "Print Order";
            this.printorder.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // quantity
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.quantity.HeaderText = "Qty.";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // itemname
            // 
            this.itemname.HeaderText = "Item Name";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Width = 200;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // discard
            // 
            this.discard.AllowUserToAddRows = false;
            this.discard.AllowUserToDeleteRows = false;
            this.discard.BackgroundColor = System.Drawing.Color.White;
            this.discard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.discard.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.discard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.discard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.discard.DefaultCellStyle = dataGridViewCellStyle10;
            this.discard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.discard.Location = new System.Drawing.Point(515, 11);
            this.discard.Margin = new System.Windows.Forms.Padding(10);
            this.discard.Name = "discard";
            this.discard.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.discard.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.discard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.discard.Size = new System.Drawing.Size(141, 279);
            this.discard.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(561, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 290);
            this.panel6.TabIndex = 32;
            // 
            // delete
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "discard";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // employeebill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 580);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeebill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " f";
            this.Load += new System.EventHandler(this.employeeinvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventory)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billitem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView inventory;
        private System.Windows.Forms.TextBox txtquan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public System.Windows.Forms.TextBox txtcusid;
        public System.Windows.Forms.TextBox txtcusname;
        private Guna.UI2.WinForms.Guna2Button btncancel;
        private System.Windows.Forms.DataGridView billitem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button printorder;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        public System.Windows.Forms.TextBox txtinnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridView discard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}