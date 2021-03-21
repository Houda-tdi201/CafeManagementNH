namespace CafeManagementNH
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgShowItems = new System.Windows.Forms.DataGridView();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.dgAddedItems = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIdOrder = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddorders = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.numQte = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.btnvalidateEditItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.idItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(15, 140);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(173, 21);
            this.cbCat.TabIndex = 0;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(289, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "      Order";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblUsername.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.lblUsername.Location = new System.Drawing.Point(15, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(173, 25);
            this.lblUsername.TabIndex = 47;
            this.lblUsername.Text = "Hello User Name!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(15, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Order Number :";
            // 
            // dgShowItems
            // 
            this.dgShowItems.AllowUserToAddRows = false;
            this.dgShowItems.AllowUserToDeleteRows = false;
            this.dgShowItems.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgShowItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgShowItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItems,
            this.ItemName,
            this.description,
            this.Price});
            this.dgShowItems.Location = new System.Drawing.Point(15, 14);
            this.dgShowItems.Name = "dgShowItems";
            this.dgShowItems.ReadOnly = true;
            this.dgShowItems.Size = new System.Drawing.Size(469, 150);
            this.dgShowItems.TabIndex = 50;
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnAddCard.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnAddCard.FlatAppearance.BorderSize = 2;
            this.btnAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCard.Font = new System.Drawing.Font("Script MT Bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCard.Location = new System.Drawing.Point(319, 182);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(131, 26);
            this.btnAddCard.TabIndex = 53;
            this.btnAddCard.Text = "Add to Card";
            this.btnAddCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // dgAddedItems
            // 
            this.dgAddedItems.AllowUserToAddRows = false;
            this.dgAddedItems.AllowUserToDeleteRows = false;
            this.dgAddedItems.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgAddedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAddedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrder,
            this.IdItem,
            this.ItemsName,
            this.Qte,
            this.PriceItem,
            this.total});
            this.dgAddedItems.Location = new System.Drawing.Point(13, 220);
            this.dgAddedItems.Name = "dgAddedItems";
            this.dgAddedItems.ReadOnly = true;
            this.dgAddedItems.Size = new System.Drawing.Size(469, 150);
            this.dgAddedItems.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(127, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotal.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.lblTotal.Location = new System.Drawing.Point(203, 375);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 25);
            this.lblTotal.TabIndex = 56;
            this.lblTotal.Text = "..........";
            // 
            // lblIdOrder
            // 
            this.lblIdOrder.AutoSize = true;
            this.lblIdOrder.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblIdOrder.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIdOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.lblIdOrder.Location = new System.Drawing.Point(152, 174);
            this.lblIdOrder.Name = "lblIdOrder";
            this.lblIdOrder.Size = new System.Drawing.Size(26, 23);
            this.lblIdOrder.TabIndex = 59;
            this.lblIdOrder.Text = "....";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnPrint.FlatAppearance.BorderSize = 4;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Script MT Bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(317, 376);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(166, 33);
            this.btnPrint.TabIndex = 60;
            this.btnPrint.Text = "Print the ticket";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox4.Image = global::CafeManagementNH.Properties.Resources.close_window_32px;
            this.pictureBox4.Location = new System.Drawing.Point(711, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 31);
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(559, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 61;
            this.label6.Text = "        Client Page";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.btnCancelItem);
            this.panel2.Controls.Add(this.btnvalidateEditItem);
            this.panel2.Controls.Add(this.btnEditOrder);
            this.panel2.Controls.Add(this.numQte);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgAddedItems);
            this.panel2.Controls.Add(this.btnAddCard);
            this.panel2.Controls.Add(this.dgShowItems);
            this.panel2.Location = new System.Drawing.Point(234, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 412);
            this.panel2.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(57, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Quantity :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.NavajoWhite;
            this.label9.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label9.Location = new System.Drawing.Point(16, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Categorie :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(774, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(73, 264);
            this.listBox1.TabIndex = 72;
            // 
            // btnAddorders
            // 
            this.btnAddorders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnAddorders.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnAddorders.FlatAppearance.BorderSize = 0;
            this.btnAddorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddorders.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddorders.Image = global::CafeManagementNH.Properties.Resources.add_32px;
            this.btnAddorders.Location = new System.Drawing.Point(189, 172);
            this.btnAddorders.Name = "btnAddorders";
            this.btnAddorders.Size = new System.Drawing.Size(32, 30);
            this.btnAddorders.TabIndex = 73;
            this.btnAddorders.UseVisualStyleBackColor = false;
            this.btnAddorders.Click += new System.EventHandler(this.btnAddorders_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnDeleteOrder.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteOrder.Image = global::CafeManagementNH.Properties.Resources.waste_32px;
            this.btnDeleteOrder.Location = new System.Drawing.Point(189, 172);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteOrder.TabIndex = 74;
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // numQte
            // 
            this.numQte.Location = new System.Drawing.Point(171, 185);
            this.numQte.Name = "numQte";
            this.numQte.Size = new System.Drawing.Size(100, 20);
            this.numQte.TabIndex = 62;
            this.numQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BackgroundImage = global::CafeManagementNH.Properties.Resources.menubackground12;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblDes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(18, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 206);
            this.panel1.TabIndex = 75;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.BackColor = System.Drawing.Color.BurlyWood;
            this.lblDes.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.lblDes.Location = new System.Drawing.Point(24, 65);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(153, 23);
            this.lblDes.TabIndex = 67;
            this.lblDes.Text = "Have a good day !";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 23);
            this.label8.TabIndex = 69;
            this.label8.Text = "Hope we see you again !";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(56)))), ((int)(((byte)(20)))));
            this.btnEditOrder.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditOrder.Image = global::CafeManagementNH.Properties.Resources.edit_32px;
            this.btnEditOrder.Location = new System.Drawing.Point(15, 373);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(32, 30);
            this.btnEditOrder.TabIndex = 63;
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(853, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(73, 264);
            this.listBox2.TabIndex = 76;
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Location = new System.Drawing.Point(849, 51);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(41, 13);
            this.lblIdUser.TabIndex = 77;
            this.lblIdUser.Text = "label10";
            // 
            // btnvalidateEditItem
            // 
            this.btnvalidateEditItem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnvalidateEditItem.FlatAppearance.BorderSize = 0;
            this.btnvalidateEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalidateEditItem.Image = global::CafeManagementNH.Properties.Resources.checked_checkbox_32px1;
            this.btnvalidateEditItem.Location = new System.Drawing.Point(15, 379);
            this.btnvalidateEditItem.Name = "btnvalidateEditItem";
            this.btnvalidateEditItem.Size = new System.Drawing.Size(33, 23);
            this.btnvalidateEditItem.TabIndex = 64;
            this.btnvalidateEditItem.UseVisualStyleBackColor = false;
            this.btnvalidateEditItem.Click += new System.EventHandler(this.btnvalidateEditItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCancelItem.FlatAppearance.BorderSize = 0;
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.Image = global::CafeManagementNH.Properties.Resources.multiply_24px1;
            this.btnCancelItem.Location = new System.Drawing.Point(49, 380);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(21, 23);
            this.btnCancelItem.TabIndex = 65;
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // idItems
            // 
            this.idItems.HeaderText = "idItems";
            this.idItems.Name = "idItems";
            this.idItems.ReadOnly = true;
            this.idItems.Width = 80;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 130;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 95;
            // 
            // IdOrder
            // 
            this.IdOrder.HeaderText = "IdOrder";
            this.IdOrder.Name = "IdOrder";
            this.IdOrder.ReadOnly = true;
            // 
            // IdItem
            // 
            this.IdItem.HeaderText = "IdItem";
            this.IdItem.Name = "IdItem";
            this.IdItem.ReadOnly = true;
            // 
            // ItemsName
            // 
            this.ItemsName.HeaderText = "Name";
            this.ItemsName.Name = "ItemsName";
            this.ItemsName.ReadOnly = true;
            this.ItemsName.Width = 135;
            // 
            // Qte
            // 
            this.Qte.HeaderText = "Qte";
            this.Qte.Name = "Qte";
            this.Qte.ReadOnly = true;
            this.Qte.Width = 90;
            // 
            // PriceItem
            // 
            this.PriceItem.HeaderText = "Price";
            this.PriceItem.Name = "PriceItem";
            this.PriceItem.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeManagementNH.Properties.Resources.realistic_coffee_background_with_drawings_79603_6071;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 478);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddorders);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIdOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.btnDeleteOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgShowItems;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.DataGridView dgAddedItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIdOrder;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddorders;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.NumericUpDown numQte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.Button btnvalidateEditItem;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}