namespace Seller
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.panel_seller = new System.Windows.Forms.Panel();
            this.update_hmp = new System.Windows.Forms.Button();
            this.new_hmp = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.home_hmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNewItem = new System.Windows.Forms.Panel();
            this.btnBackNew = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtQuantityNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSizeNew = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.panelUpIt = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtQuantityUp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.btnBackUP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelItemDetails = new System.Windows.Forms.Panel();
            this.btnBackDetails = new System.Windows.Forms.Button();
            this.dgItemDetails = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_seller.SuspendLayout();
            this.panelNewItem.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelUpIt.SuspendLayout();
            this.panelItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_seller
            // 
            this.panel_seller.BackColor = System.Drawing.Color.White;
            this.panel_seller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_seller.Controls.Add(this.update_hmp);
            this.panel_seller.Controls.Add(this.new_hmp);
            this.panel_seller.Controls.Add(this.btnView);
            this.panel_seller.Controls.Add(this.home_hmp);
            this.panel_seller.Controls.Add(this.label1);
            this.panel_seller.Location = new System.Drawing.Point(0, 0);
            this.panel_seller.Name = "panel_seller";
            this.panel_seller.Size = new System.Drawing.Size(680, 380);
            this.panel_seller.TabIndex = 0;
            // 
            // update_hmp
            // 
            this.update_hmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_hmp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_hmp.Location = new System.Drawing.Point(240, 252);
            this.update_hmp.Name = "update_hmp";
            this.update_hmp.Size = new System.Drawing.Size(200, 40);
            this.update_hmp.TabIndex = 4;
            this.update_hmp.Text = "U p d a t e";
            this.update_hmp.UseVisualStyleBackColor = true;
            this.update_hmp.Click += new System.EventHandler(this.BtnUpdateItem_Click);
            // 
            // new_hmp
            // 
            this.new_hmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_hmp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_hmp.Location = new System.Drawing.Point(240, 191);
            this.new_hmp.Name = "new_hmp";
            this.new_hmp.Size = new System.Drawing.Size(200, 40);
            this.new_hmp.TabIndex = 3;
            this.new_hmp.Text = "N e w";
            this.new_hmp.UseVisualStyleBackColor = true;
            this.new_hmp.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(240, 312);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(200, 40);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "V i e w";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // home_hmp
            // 
            this.home_hmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_hmp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_hmp.Location = new System.Drawing.Point(240, 130);
            this.home_hmp.Name = "home_hmp";
            this.home_hmp.Size = new System.Drawing.Size(200, 40);
            this.home_hmp.TabIndex = 1;
            this.home_hmp.Text = "H o m e";
            this.home_hmp.UseVisualStyleBackColor = true;
            this.home_hmp.Click += new System.EventHandler(this.Home_hmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "S E L L E R";
            // 
            // panelNewItem
            // 
            this.panelNewItem.BackColor = System.Drawing.Color.White;
            this.panelNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNewItem.Controls.Add(this.btnBackNew);
            this.panelNewItem.Controls.Add(this.btnSubmit);
            this.panelNewItem.Controls.Add(this.txtQuantityNew);
            this.panelNewItem.Controls.Add(this.label5);
            this.panelNewItem.Controls.Add(this.cbSizeNew);
            this.panelNewItem.Controls.Add(this.label4);
            this.panelNewItem.Controls.Add(this.txtNameNew);
            this.panelNewItem.Controls.Add(this.label3);
            this.panelNewItem.Controls.Add(this.label2);
            this.panelNewItem.Location = new System.Drawing.Point(0, 0);
            this.panelNewItem.Name = "panelNewItem";
            this.panelNewItem.Size = new System.Drawing.Size(680, 380);
            this.panelNewItem.TabIndex = 1;
            // 
            // btnBackNew
            // 
            this.btnBackNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackNew.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNew.Location = new System.Drawing.Point(376, 300);
            this.btnBackNew.Name = "btnBackNew";
            this.btnBackNew.Size = new System.Drawing.Size(200, 40);
            this.btnBackNew.TabIndex = 8;
            this.btnBackNew.Text = "B a c k";
            this.btnBackNew.UseVisualStyleBackColor = true;
            this.btnBackNew.Click += new System.EventHandler(this.btnBackNew_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(105, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 40);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "S u b m i t";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitNp_Click);
            // 
            // txtQuantityNew
            // 
            this.txtQuantityNew.Location = new System.Drawing.Point(323, 245);
            this.txtQuantityNew.Name = "txtQuantityNew";
            this.txtQuantityNew.Size = new System.Drawing.Size(200, 20);
            this.txtQuantityNew.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Q u a n t i t y";
            // 
            // cbSizeNew
            // 
            this.cbSizeNew.DisplayMember = "c";
            this.cbSizeNew.FormattingEnabled = true;
            this.cbSizeNew.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cbSizeNew.Location = new System.Drawing.Point(323, 193);
            this.cbSizeNew.Name = "cbSizeNew";
            this.cbSizeNew.Size = new System.Drawing.Size(200, 21);
            this.cbSizeNew.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "S i z e";
            // 
            // txtNameNew
            // 
            this.txtNameNew.Location = new System.Drawing.Point(323, 140);
            this.txtNameNew.Name = "txtNameNew";
            this.txtNameNew.Size = new System.Drawing.Size(200, 20);
            this.txtNameNew.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "N a m e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "N E W  I T E M";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackColor = System.Drawing.Color.White;
            this.panelUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUpdate.Controls.Add(this.panelUpIt);
            this.panelUpdate.Controls.Add(this.txtItemId);
            this.panelUpdate.Controls.Add(this.btnBackUP);
            this.panelUpdate.Controls.Add(this.label7);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.label6);
            this.panelUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(680, 380);
            this.panelUpdate.TabIndex = 2;
            // 
            // panelUpIt
            // 
            this.panelUpIt.BackColor = System.Drawing.Color.White;
            this.panelUpIt.Controls.Add(this.textBox2);
            this.panelUpIt.Controls.Add(this.textBox1);
            this.panelUpIt.Controls.Add(this.lblSize);
            this.panelUpIt.Controls.Add(this.lblName);
            this.panelUpIt.Controls.Add(this.txtQuantityUp);
            this.panelUpIt.Controls.Add(this.label10);
            this.panelUpIt.Controls.Add(this.label9);
            this.panelUpIt.Controls.Add(this.label8);
            this.panelUpIt.Location = new System.Drawing.Point(132, 162);
            this.panelUpIt.Name = "panelUpIt";
            this.panelUpIt.Size = new System.Drawing.Size(406, 118);
            this.panelUpIt.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(92, 38);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 13);
            this.lblSize.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(92, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 7;
            // 
            // txtQuantityUp
            // 
            this.txtQuantityUp.Location = new System.Drawing.Point(188, 87);
            this.txtQuantityUp.Name = "txtQuantityUp";
            this.txtQuantityUp.Size = new System.Drawing.Size(200, 20);
            this.txtQuantityUp.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Q u a n t i t y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "S i z e";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "N a m e";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(320, 139);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(200, 20);
            this.txtItemId.TabIndex = 2;
            this.txtItemId.TextChanged += new System.EventHandler(this.txtItemId_TextChanged);
            this.txtItemId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemId_KeyPress);
            // 
            // btnBackUP
            // 
            this.btnBackUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUP.Location = new System.Drawing.Point(376, 300);
            this.btnBackUP.Name = "btnBackUP";
            this.btnBackUP.Size = new System.Drawing.Size(200, 40);
            this.btnBackUP.TabIndex = 9;
            this.btnBackUP.Text = "B a c k";
            this.btnBackUP.UseVisualStyleBackColor = true;
            this.btnBackUP.Click += new System.EventHandler(this.btnBackUP_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "I t e m  I D";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(105, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "U p d a t e";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "U P D A T E  I T E M";
            // 
            // panelItemDetails
            // 
            this.panelItemDetails.BackColor = System.Drawing.Color.White;
            this.panelItemDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelItemDetails.Controls.Add(this.btnBackDetails);
            this.panelItemDetails.Controls.Add(this.dgItemDetails);
            this.panelItemDetails.Controls.Add(this.label11);
            this.panelItemDetails.Location = new System.Drawing.Point(0, 0);
            this.panelItemDetails.Name = "panelItemDetails";
            this.panelItemDetails.Size = new System.Drawing.Size(680, 380);
            this.panelItemDetails.TabIndex = 3;
            // 
            // btnBackDetails
            // 
            this.btnBackDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackDetails.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDetails.Location = new System.Drawing.Point(425, 300);
            this.btnBackDetails.Name = "btnBackDetails";
            this.btnBackDetails.Size = new System.Drawing.Size(200, 40);
            this.btnBackDetails.TabIndex = 2;
            this.btnBackDetails.Text = "B a c k";
            this.btnBackDetails.UseVisualStyleBackColor = true;
            this.btnBackDetails.Click += new System.EventHandler(this.btnBackDetails_Click);
            // 
            // dgItemDetails
            // 
            this.dgItemDetails.AllowUserToAddRows = false;
            this.dgItemDetails.AllowUserToDeleteRows = false;
            this.dgItemDetails.AllowUserToOrderColumns = true;
            this.dgItemDetails.AllowUserToResizeColumns = false;
            this.dgItemDetails.AllowUserToResizeRows = false;
            this.dgItemDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemDetails.Location = new System.Drawing.Point(55, 130);
            this.dgItemDetails.Name = "dgItemDetails";
            this.dgItemDetails.Size = new System.Drawing.Size(570, 160);
            this.dgItemDetails.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(168, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(345, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "I T E M  D E T A I L S";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 60);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(620, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelItemDetails);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelNewItem);
            this.Controls.Add(this.panel_seller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel_seller.ResumeLayout(false);
            this.panel_seller.PerformLayout();
            this.panelNewItem.ResumeLayout(false);
            this.panelNewItem.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelUpIt.ResumeLayout(false);
            this.panelUpIt.PerformLayout();
            this.panelItemDetails.ResumeLayout(false);
            this.panelItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_seller;
        private System.Windows.Forms.Button update_hmp;
        private System.Windows.Forms.Button new_hmp;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button home_hmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNewItem;
        private System.Windows.Forms.TextBox txtNameNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSizeNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantityNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantityUp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelItemDetails;
        private System.Windows.Forms.DataGridView dgItemDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBackUP;
        private System.Windows.Forms.Button btnBackNew;
        private System.Windows.Forms.Button btnBackDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelUpIt;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
    }
}

