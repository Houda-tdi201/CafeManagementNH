namespace CafeManagementNH
{
    partial class OrderManage
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dgAddOrders = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnvalidateEditItem = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.numEditItem = new System.Windows.Forms.NumericUpDown();
            this.cbEditItem = new System.Windows.Forms.ComboBox();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnValidateItem = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numQte = new System.Windows.Forms.NumericUpDown();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstIdItem = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditItem)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order Manage";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(29, 81);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(160, 21);
            this.cbClient.TabIndex = 7;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrder,
            this.DateOrder});
            this.dgOrders.Location = new System.Drawing.Point(29, 108);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.Size = new System.Drawing.Size(239, 263);
            this.dgOrders.TabIndex = 8;
            this.dgOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellEnter);
            this.dgOrders.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellLeave);
            // 
            // IdOrder
            // 
            this.IdOrder.HeaderText = "IdOrder";
            this.IdOrder.Name = "IdOrder";
            this.IdOrder.ReadOnly = true;
            this.IdOrder.Width = 60;
            // 
            // DateOrder
            // 
            this.DateOrder.HeaderText = "DateOrder";
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.ReadOnly = true;
            this.DateOrder.Width = 130;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnDeleteOrder.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 3;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Script MT Bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrder.Location = new System.Drawing.Point(150, 377);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(107, 31);
            this.btnDeleteOrder.TabIndex = 32;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnAddOrder.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnAddOrder.FlatAppearance.BorderSize = 3;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Script MT Bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.Location = new System.Drawing.Point(42, 377);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(102, 31);
            this.btnAddOrder.TabIndex = 31;
            this.btnAddOrder.Text = "New Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dgAddOrders
            // 
            this.dgAddOrders.AllowUserToAddRows = false;
            this.dgAddOrders.AllowUserToDeleteRows = false;
            this.dgAddOrders.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgAddOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAddOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.IdItem,
            this.itemName,
            this.Qte,
            this.Price,
            this.total});
            this.dgAddOrders.Location = new System.Drawing.Point(17, 24);
            this.dgAddOrders.Name = "dgAddOrders";
            this.dgAddOrders.ReadOnly = true;
            this.dgAddOrders.Size = new System.Drawing.Size(392, 119);
            this.dgAddOrders.TabIndex = 33;
            // 
            // code
            // 
            this.code.HeaderText = "code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // IdItem
            // 
            this.IdItem.HeaderText = "IdItem";
            this.IdItem.Name = "IdItem";
            this.IdItem.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "itemName";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // Qte
            // 
            this.Qte.HeaderText = "Qte";
            this.Qte.Name = "Qte";
            this.Qte.ReadOnly = true;
            this.Qte.Width = 60;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Controls.Add(this.panelAdd);
            this.panel1.Controls.Add(this.btnvalidateEditItem);
            this.panel1.Controls.Add(this.btnCancelItem);
            this.panel1.Controls.Add(this.btnValidateItem);
            this.panel1.Controls.Add(this.btnDeleteItems);
            this.panel1.Controls.Add(this.btnEditItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.dgAddOrders);
            this.panel1.Location = new System.Drawing.Point(286, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 371);
            this.panel1.TabIndex = 34;
            // 
            // btnvalidateEditItem
            // 
            this.btnvalidateEditItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnvalidateEditItem.FlatAppearance.BorderSize = 0;
            this.btnvalidateEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalidateEditItem.Image = global::CafeManagementNH.Properties.Resources.checked_checkbox_32px1;
            this.btnvalidateEditItem.Location = new System.Drawing.Point(372, 217);
            this.btnvalidateEditItem.Name = "btnvalidateEditItem";
            this.btnvalidateEditItem.Size = new System.Drawing.Size(33, 23);
            this.btnvalidateEditItem.TabIndex = 54;
            this.btnvalidateEditItem.UseVisualStyleBackColor = false;
            this.btnvalidateEditItem.Click += new System.EventHandler(this.btnvalidateEditItem_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.BurlyWood;
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.label8);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.txtEditPrice);
            this.panelEdit.Controls.Add(this.numEditItem);
            this.panelEdit.Controls.Add(this.cbEditItem);
            this.panelEdit.Location = new System.Drawing.Point(17, 168);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(256, 156);
            this.panelEdit.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(37, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 33);
            this.label7.TabIndex = 48;
            this.label7.Text = "Edit Order Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label8.Location = new System.Drawing.Point(12, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Price :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label9.Location = new System.Drawing.Point(12, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "Quantite :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.BurlyWood;
            this.label10.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label10.Location = new System.Drawing.Point(12, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Items :";
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(92, 110);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(100, 20);
            this.txtEditPrice.TabIndex = 43;
            // 
            // numEditItem
            // 
            this.numEditItem.Location = new System.Drawing.Point(92, 80);
            this.numEditItem.Name = "numEditItem";
            this.numEditItem.Size = new System.Drawing.Size(120, 20);
            this.numEditItem.TabIndex = 44;
            this.numEditItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbEditItem
            // 
            this.cbEditItem.FormattingEnabled = true;
            this.cbEditItem.Location = new System.Drawing.Point(92, 53);
            this.cbEditItem.Name = "cbEditItem";
            this.cbEditItem.Size = new System.Drawing.Size(160, 21);
            this.cbEditItem.TabIndex = 43;
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCancelItem.FlatAppearance.BorderSize = 0;
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.Image = global::CafeManagementNH.Properties.Resources.multiply_24px1;
            this.btnCancelItem.Location = new System.Drawing.Point(378, 250);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(21, 23);
            this.btnCancelItem.TabIndex = 53;
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // btnValidateItem
            // 
            this.btnValidateItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnValidateItem.FlatAppearance.BorderSize = 0;
            this.btnValidateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateItem.Image = global::CafeManagementNH.Properties.Resources.checked_checkbox_32px1;
            this.btnValidateItem.Location = new System.Drawing.Point(372, 217);
            this.btnValidateItem.Name = "btnValidateItem";
            this.btnValidateItem.Size = new System.Drawing.Size(33, 23);
            this.btnValidateItem.TabIndex = 52;
            this.btnValidateItem.UseVisualStyleBackColor = false;
            this.btnValidateItem.Click += new System.EventHandler(this.btnValidateItem_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.BurlyWood;
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.txtPrice);
            this.panelAdd.Controls.Add(this.numQte);
            this.panelAdd.Controls.Add(this.cbItems);
            this.panelAdd.Location = new System.Drawing.Point(49, 168);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(256, 156);
            this.panelAdd.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(32, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 33);
            this.label6.TabIndex = 48;
            this.label6.Text = "Add Order Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Quantite :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Items :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(92, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 43;
            // 
            // numQte
            // 
            this.numQte.Location = new System.Drawing.Point(92, 80);
            this.numQte.Name = "numQte";
            this.numQte.Size = new System.Drawing.Size(120, 20);
            this.numQte.TabIndex = 44;
            this.numQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(92, 53);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(160, 21);
            this.cbItems.TabIndex = 43;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnDeleteItems.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnDeleteItems.FlatAppearance.BorderSize = 0;
            this.btnDeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItems.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteItems.Image = global::CafeManagementNH.Properties.Resources.waste_32px;
            this.btnDeleteItems.Location = new System.Drawing.Point(334, 270);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteItems.TabIndex = 36;
            this.btnDeleteItems.UseVisualStyleBackColor = false;
            this.btnDeleteItems.Click += new System.EventHandler(this.btnDeleteItems_Click);
            // 
            // btnEditItems
            // 
            this.btnEditItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnEditItems.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnEditItems.FlatAppearance.BorderSize = 0;
            this.btnEditItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItems.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditItems.Image = global::CafeManagementNH.Properties.Resources.edit_32px;
            this.btnEditItems.Location = new System.Drawing.Point(334, 234);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(32, 30);
            this.btnEditItems.TabIndex = 35;
            this.btnEditItems.UseVisualStyleBackColor = false;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnAddItems.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnAddItems.FlatAppearance.BorderSize = 0;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItems.Image = global::CafeManagementNH.Properties.Resources.add_32px;
            this.btnAddItems.Location = new System.Drawing.Point(334, 198);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(32, 30);
            this.btnAddItems.TabIndex = 34;
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox4.Image = global::CafeManagementNH.Properties.Resources.close_window_32px;
            this.pictureBox4.Location = new System.Drawing.Point(701, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 31);
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label1.Image = global::CafeManagementNH.Properties.Resources.manager_32px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(550, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "        Admin Page";
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnAddClient.FlatAppearance.BorderSize = 2;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Script MT Bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClient.Location = new System.Drawing.Point(195, 81);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(73, 25);
            this.btnAddClient.TabIndex = 43;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(740, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 290);
            this.listBox1.TabIndex = 44;
            // 
            // lstIdItem
            // 
            this.lstIdItem.FormattingEnabled = true;
            this.lstIdItem.Location = new System.Drawing.Point(866, 71);
            this.lstIdItem.Name = "lstIdItem";
            this.lstIdItem.Size = new System.Drawing.Size(61, 290);
            this.lstIdItem.TabIndex = 45;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotal.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.lblTotal.Location = new System.Drawing.Point(138, 333);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 25);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total :";
            // 
            // OrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeManagementNH.Properties.Resources.realistic_coffee_background_with_drawings_79603_607;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstIdItem);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderManage";
            this.Text = "OrderManage";
            this.Load += new System.EventHandler(this.OrderManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditItem)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dgAddOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numQte;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnValidateItem;
        private System.Windows.Forms.ListBox lstIdItem;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.NumericUpDown numEditItem;
        private System.Windows.Forms.ComboBox cbEditItem;
        private System.Windows.Forms.Button btnvalidateEditItem;
        private System.Windows.Forms.Label lblTotal;
    }
}