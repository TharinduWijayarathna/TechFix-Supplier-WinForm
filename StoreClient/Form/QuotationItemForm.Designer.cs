namespace StoreClient
{
    partial class QuotationItemForm
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dgvItems.Location = new System.Drawing.Point(357, 6);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(647, 439);
            this.dgvItems.TabIndex = 24;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 43);
            this.button2.TabIndex = 61;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(245, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 43);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 11);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(214, 20);
            this.txtID.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(133, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 43);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 43);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(133, 167);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(214, 104);
            this.txtDes.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Description";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(137, 93);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(214, 20);
            this.txtStock.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 20);
            this.txtName.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 128);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(214, 20);
            this.txtPrice.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Price";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // QuotationItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 449);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItems);
            this.Name = "QuotationItemForm";
            this.Text = "QuotationItemForm";
            this.Load += new System.EventHandler(this.QuotationItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
    }
}