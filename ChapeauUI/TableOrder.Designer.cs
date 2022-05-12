
namespace ChapeauUI
{
    partial class TableOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOrder));
            this.LunchBtn = new System.Windows.Forms.Button();
            this.DinnerBtn = new System.Windows.Forms.Button();
            this.DrinkBtn = new System.Windows.Forms.Button();
            this.LvCatagory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvSubCatagory = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvOverview = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddItem = new System.Windows.Forms.Button();
            this.CommentTxt = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LunchBtn
            // 
            this.LunchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.LunchBtn.Location = new System.Drawing.Point(89, 160);
            this.LunchBtn.Name = "LunchBtn";
            this.LunchBtn.Size = new System.Drawing.Size(110, 60);
            this.LunchBtn.TabIndex = 0;
            this.LunchBtn.Text = "Lunch";
            this.LunchBtn.UseVisualStyleBackColor = true;
            this.LunchBtn.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // DinnerBtn
            // 
            this.DinnerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.DinnerBtn.Location = new System.Drawing.Point(89, 239);
            this.DinnerBtn.Name = "DinnerBtn";
            this.DinnerBtn.Size = new System.Drawing.Size(110, 57);
            this.DinnerBtn.TabIndex = 1;
            this.DinnerBtn.Text = "Dinner";
            this.DinnerBtn.UseVisualStyleBackColor = true;
            this.DinnerBtn.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // DrinkBtn
            // 
            this.DrinkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.DrinkBtn.Location = new System.Drawing.Point(89, 312);
            this.DrinkBtn.Name = "DrinkBtn";
            this.DrinkBtn.Size = new System.Drawing.Size(110, 57);
            this.DrinkBtn.TabIndex = 2;
            this.DrinkBtn.Text = "Drinks";
            this.DrinkBtn.UseVisualStyleBackColor = true;
            this.DrinkBtn.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // LvCatagory
            // 
            this.LvCatagory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LvCatagory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LvCatagory.HideSelection = false;
            this.LvCatagory.Location = new System.Drawing.Point(244, 104);
            this.LvCatagory.MultiSelect = false;
            this.LvCatagory.Name = "LvCatagory";
            this.LvCatagory.Size = new System.Drawing.Size(95, 178);
            this.LvCatagory.TabIndex = 3;
            this.LvCatagory.UseCompatibleStateImageBehavior = false;
            this.LvCatagory.View = System.Windows.Forms.View.Details;
            this.LvCatagory.SelectedIndexChanged += new System.EventHandler(this.lvSub_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Choose From";
            this.columnHeader1.Width = 90;
            // 
            // LvSubCatagory
            // 
            this.LvSubCatagory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8});
            this.LvSubCatagory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LvSubCatagory.HideSelection = false;
            this.LvSubCatagory.Location = new System.Drawing.Point(367, 104);
            this.LvSubCatagory.MultiSelect = false;
            this.LvSubCatagory.Name = "LvSubCatagory";
            this.LvSubCatagory.Size = new System.Drawing.Size(230, 178);
            this.LvSubCatagory.TabIndex = 4;
            this.LvSubCatagory.UseCompatibleStateImageBehavior = false;
            this.LvSubCatagory.View = System.Windows.Forms.View.Details;
            this.LvSubCatagory.SelectedIndexChanged += new System.EventHandler(this.lvItem_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            this.columnHeader8.Width = 50;
            // 
            // LvOverview
            // 
            this.LvOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LvOverview.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LvOverview.HideSelection = false;
            this.LvOverview.Location = new System.Drawing.Point(233, 312);
            this.LvOverview.Name = "LvOverview";
            this.LvOverview.Size = new System.Drawing.Size(364, 116);
            this.LvOverview.TabIndex = 5;
            this.LvOverview.UseCompatibleStateImageBehavior = false;
            this.LvOverview.View = System.Windows.Forms.View.Details;
            this.LvOverview.SelectedIndexChanged += new System.EventHandler(this.lvOverview_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 175;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Remark";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(653, 199);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(162, 57);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // CommentTxt
            // 
            this.CommentTxt.Location = new System.Drawing.Point(653, 138);
            this.CommentTxt.Multiline = true;
            this.CommentTxt.Name = "CommentTxt";
            this.CommentTxt.Size = new System.Drawing.Size(162, 40);
            this.CommentTxt.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblAmount.Location = new System.Drawing.Point(650, 90);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(48, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(749, 90);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(66, 20);
            this.AmountTxt.TabIndex = 9;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblRemark.Location = new System.Drawing.Point(650, 122);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(45, 13);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "Remark";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(653, 282);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(164, 57);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblHeadline.Location = new System.Drawing.Point(440, 30);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(90, 28);
            this.lblHeadline.TabIndex = 12;
            this.lblHeadline.Text = "Table # 2";
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCompleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnCompleteOrder.Location = new System.Drawing.Point(653, 360);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(162, 57);
            this.btnCompleteOrder.TabIndex = 13;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = false;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(705, 19);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 49);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimeLbl.Location = new System.Drawing.Point(229, 19);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(74, 20);
            this.TimeLbl.TabIndex = 17;
            this.TimeLbl.Text = "Footnote";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(365, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Item Overview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Selected Item Overview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(247, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sub Category";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.AutoSize = true;
            this.UserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserNameTxt.Location = new System.Drawing.Point(229, 44);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(43, 20);
            this.UserNameTxt.TabIndex = 24;
            this.UserNameTxt.Text = "User";
            // 
            // TableOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.CommentTxt);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.LvOverview);
            this.Controls.Add(this.LvSubCatagory);
            this.Controls.Add(this.LvCatagory);
            this.Controls.Add(this.DrinkBtn);
            this.Controls.Add(this.DinnerBtn);
            this.Controls.Add(this.LunchBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LunchBtn;
        private System.Windows.Forms.Button DinnerBtn;
        private System.Windows.Forms.Button DrinkBtn;
        private System.Windows.Forms.ListView LvCatagory;
        private System.Windows.Forms.ListView LvSubCatagory;
        private System.Windows.Forms.ListView LvOverview;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox CommentTxt;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserNameTxt;
    }
}