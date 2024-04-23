namespace PointofSale.Model
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDineIn = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnTakeout = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnKot = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnBillList = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnHold = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnNew = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ucProduct1 = new PointofSale.Model.ucProduct();
            this.ucProduct2 = new PointofSale.Model.ucProduct();
            this.ucProduct3 = new PointofSale.Model.ucProduct();
            this.guna2ShadowPanel3.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(217)))), ((int)(((byte)(194)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 532);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1087, 100);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.btnExit);
            this.guna2ShadowPanel3.Controls.Add(this.lblWaiter);
            this.guna2ShadowPanel3.Controls.Add(this.lblTable);
            this.guna2ShadowPanel3.Controls.Add(this.btnDineIn);
            this.guna2ShadowPanel3.Controls.Add(this.btnTakeout);
            this.guna2ShadowPanel3.Controls.Add(this.btnDelivery);
            this.guna2ShadowPanel3.Controls.Add(this.btnKot);
            this.guna2ShadowPanel3.Controls.Add(this.btnBillList);
            this.guna2ShadowPanel3.Controls.Add(this.btnHold);
            this.guna2ShadowPanel3.Controls.Add(this.btnNew);
            this.guna2ShadowPanel3.Controls.Add(this.label1);
            this.guna2ShadowPanel3.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(217)))), ((int)(((byte)(194)))));
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(1087, 100);
            this.guna2ShadowPanel3.TabIndex = 1;
            this.guna2ShadowPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel3_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BorderRadius = 15;
            this.btnExit.CustomClick = true;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1029, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 32);
            this.btnExit.TabIndex = 12;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Poppins ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.lblWaiter.Location = new System.Drawing.Point(882, 42);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(96, 39);
            this.lblWaiter.TabIndex = 11;
            this.lblWaiter.Text = "Waiter";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Poppins ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.lblTable.Location = new System.Drawing.Point(882, 16);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(81, 39);
            this.lblTable.TabIndex = 10;
            this.lblTable.Text = "Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryPanel.Controls.Add(this.guna2Button1);
            this.CategoryPanel.Location = new System.Drawing.Point(12, 126);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(119, 393);
            this.CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.Controls.Add(this.ucProduct1);
            this.ProductPanel.Controls.Add(this.ucProduct2);
            this.ProductPanel.Controls.Add(this.ucProduct3);
            this.ProductPanel.Location = new System.Drawing.Point(137, 126);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(517, 393);
            this.ProductPanel.TabIndex = 3;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvvid,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(660, 126);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 35;
            this.guna2DataGridView1.Size = new System.Drawing.Size(405, 393);
            this.guna2DataGridView1.TabIndex = 8;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvvid
            // 
            this.dgvvid.HeaderText = "Id";
            this.dgvvid.Name = "dgvvid";
            this.dgvvid.ReadOnly = true;
            this.dgvvid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 30F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 30;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 30;
            // 
            // dgvPrice
            // 
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 70F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 70;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 70;
            // 
            // btnDineIn
            // 
            this.btnDineIn.BorderRadius = 15;
            this.btnDineIn.Checked = true;
            this.btnDineIn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnDineIn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDineIn.CheckedState.Image = global::PointofSale.Properties.Resources.Dine_inwhite;
            this.btnDineIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDineIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDineIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDineIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDineIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.btnDineIn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDineIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnDineIn.Image = global::PointofSale.Properties.Resources.Dine_infillcolor;
            this.btnDineIn.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDineIn.Location = new System.Drawing.Point(792, 16);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Size = new System.Drawing.Size(84, 65);
            this.btnDineIn.TabIndex = 9;
            this.btnDineIn.Text = "DINE-IN";
            // 
            // btnTakeout
            // 
            this.btnTakeout.BorderRadius = 15;
            this.btnTakeout.Checked = true;
            this.btnTakeout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnTakeout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTakeout.CheckedState.Image = global::PointofSale.Properties.Resources.take_awaywhite;
            this.btnTakeout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTakeout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.btnTakeout.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnTakeout.Image = global::PointofSale.Properties.Resources.take_awayfill;
            this.btnTakeout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTakeout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTakeout.Location = new System.Drawing.Point(698, 16);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Size = new System.Drawing.Size(88, 65);
            this.btnTakeout.TabIndex = 8;
            this.btnTakeout.Text = "TAKE-OUT";
            // 
            // btnDelivery
            // 
            this.btnDelivery.BorderRadius = 15;
            this.btnDelivery.Checked = true;
            this.btnDelivery.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnDelivery.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.CheckedState.Image = global::PointofSale.Properties.Resources.motorbikewhite1;
            this.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.btnDelivery.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnDelivery.Image = global::PointofSale.Properties.Resources.motorbikefill;
            this.btnDelivery.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelivery.Location = new System.Drawing.Point(608, 16);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(84, 65);
            this.btnDelivery.TabIndex = 7;
            this.btnDelivery.Text = "DELIVERY";
            // 
            // btnKot
            // 
            this.btnKot.BorderRadius = 15;
            this.btnKot.Checked = true;
            this.btnKot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnKot.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnKot.CheckedState.Image = global::PointofSale.Properties.Resources.chefwhite;
            this.btnKot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.btnKot.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnKot.Image = global::PointofSale.Properties.Resources.cheffillcolor;
            this.btnKot.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKot.Location = new System.Drawing.Point(518, 16);
            this.btnKot.Name = "btnKot";
            this.btnKot.Size = new System.Drawing.Size(84, 65);
            this.btnKot.TabIndex = 6;
            this.btnKot.Text = "KOT";
            // 
            // btnBillList
            // 
            this.btnBillList.BorderRadius = 15;
            this.btnBillList.Checked = true;
            this.btnBillList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnBillList.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBillList.CheckedState.Image = global::PointofSale.Properties.Resources.reportwhite;
            this.btnBillList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBillList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBillList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBillList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBillList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.btnBillList.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnBillList.Image = global::PointofSale.Properties.Resources.reportfillcolor;
            this.btnBillList.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBillList.Location = new System.Drawing.Point(428, 16);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(84, 65);
            this.btnBillList.TabIndex = 5;
            this.btnBillList.Text = "BILL LIST";
            // 
            // btnHold
            // 
            this.btnHold.BorderRadius = 15;
            this.btnHold.Checked = true;
            this.btnHold.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnHold.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHold.CheckedState.Image = global::PointofSale.Properties.Resources.holdwhite;
            this.btnHold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.btnHold.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnHold.Image = global::PointofSale.Properties.Resources.holdfill;
            this.btnHold.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHold.Location = new System.Drawing.Point(338, 16);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(84, 65);
            this.btnHold.TabIndex = 4;
            this.btnHold.Text = "HOLD";
            // 
            // btnNew
            // 
            this.btnNew.BorderRadius = 15;
            this.btnNew.Checked = true;
            this.btnNew.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnNew.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnNew.CheckedState.Image = global::PointofSale.Properties.Resources.newwhite;
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(96)))));
            this.btnNew.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnNew.Image = global::PointofSale.Properties.Resources.newfill;
            this.btnNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNew.Location = new System.Drawing.Point(248, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 65);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "NEW";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PointofSale.Properties.Resources.fast_food__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 21);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 60);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(116, 45);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // ucProduct1
            // 
            this.ucProduct1.id = 0;
            this.ucProduct1.Location = new System.Drawing.Point(3, 3);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.PCategory = null;
            this.ucProduct1.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct1.PImage")));
            this.ucProduct1.PName = "Product Name";
            this.ucProduct1.PPrice = null;
            this.ucProduct1.Size = new System.Drawing.Size(166, 190);
            this.ucProduct1.TabIndex = 0;
            // 
            // ucProduct2
            // 
            this.ucProduct2.id = 0;
            this.ucProduct2.Location = new System.Drawing.Point(175, 3);
            this.ucProduct2.Name = "ucProduct2";
            this.ucProduct2.PCategory = null;
            this.ucProduct2.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct2.PImage")));
            this.ucProduct2.PName = "Product Name";
            this.ucProduct2.PPrice = null;
            this.ucProduct2.Size = new System.Drawing.Size(166, 190);
            this.ucProduct2.TabIndex = 1;
            // 
            // ucProduct3
            // 
            this.ucProduct3.id = 0;
            this.ucProduct3.Location = new System.Drawing.Point(347, 3);
            this.ucProduct3.Name = "ucProduct3";
            this.ucProduct3.PCategory = null;
            this.ucProduct3.PImage = ((System.Drawing.Image)(resources.GetObject("ucProduct3.PImage")));
            this.ucProduct3.PName = "Product Name";
            this.ucProduct3.PPrice = null;
            this.ucProduct3.Size = new System.Drawing.Size(166, 190);
            this.ucProduct3.TabIndex = 2;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1087, 632);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            this.CategoryPanel.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton btnNew;
        private Guna.UI2.WinForms.Guna2TileButton btnHold;
        private Guna.UI2.WinForms.Guna2TileButton btnBillList;
        private Guna.UI2.WinForms.Guna2TileButton btnDelivery;
        private Guna.UI2.WinForms.Guna2TileButton btnKot;
        private Guna.UI2.WinForms.Guna2TileButton btnDineIn;
        private Guna.UI2.WinForms.Guna2TileButton btnTakeout;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTable;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ucProduct ucProduct1;
        private ucProduct ucProduct2;
        private ucProduct ucProduct3;
    }
}