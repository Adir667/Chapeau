
namespace ChapeauUI
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.lvPayment = new System.Windows.Forms.ListView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblToalAmount = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.lvPaymentMethod = new System.Windows.Forms.ListView();
            this.btnEditAmount = new System.Windows.Forms.Button();
            this.lblToPay = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvPayment
            // 
            this.lvPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPayment.HideSelection = false;
            this.lvPayment.Location = new System.Drawing.Point(136, 92);
            this.lvPayment.Name = "lvPayment";
            this.lvPayment.Size = new System.Drawing.Size(304, 168);
            this.lvPayment.TabIndex = 1;
            this.lvPayment.UseCompatibleStateImageBehavior = false;
            this.lvPayment.View = System.Windows.Forms.View.Details;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(646, 36);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblToalAmount
            // 
            this.lblToalAmount.AutoSize = true;
            this.lblToalAmount.Location = new System.Drawing.Point(133, 263);
            this.lblToalAmount.Name = "lblToalAmount";
            this.lblToalAmount.Size = new System.Drawing.Size(34, 13);
            this.lblToalAmount.TabIndex = 3;
            this.lblToalAmount.Text = "Total:";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(261, 263);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(31, 13);
            this.lblVat.TabIndex = 4;
            this.lblVat.Text = "VAT:";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(136, 381);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(480, 33);
            this.btnConfirmPayment.TabIndex = 5;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            // 
            // lvPaymentMethod
            // 
            this.lvPaymentMethod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lvPaymentMethod.HideSelection = false;
            this.lvPaymentMethod.Location = new System.Drawing.Point(461, 92);
            this.lvPaymentMethod.Name = "lvPaymentMethod";
            this.lvPaymentMethod.Size = new System.Drawing.Size(155, 168);
            this.lvPaymentMethod.TabIndex = 6;
            this.lvPaymentMethod.UseCompatibleStateImageBehavior = false;
            this.lvPaymentMethod.View = System.Windows.Forms.View.Details;
            // 
            // btnEditAmount
            // 
            this.btnEditAmount.Location = new System.Drawing.Point(342, 324);
            this.btnEditAmount.Name = "btnEditAmount";
            this.btnEditAmount.Size = new System.Drawing.Size(98, 23);
            this.btnEditAmount.TabIndex = 7;
            this.btnEditAmount.Text = "Edit";
            this.btnEditAmount.UseVisualStyleBackColor = true;
            // 
            // lblToPay
            // 
            this.lblToPay.AutoSize = true;
            this.lblToPay.Location = new System.Drawing.Point(133, 331);
            this.lblToPay.Name = "lblToPay";
            this.lblToPay.Size = new System.Drawing.Size(51, 13);
            this.lblToPay.TabIndex = 8;
            this.lblToPay.Text = "Paymnet:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(192, 324);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 20);
            this.txtPayment.TabIndex = 9;
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeadline.Location = new System.Drawing.Point(293, 36);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(188, 26);
            this.lblHeadline.TabIndex = 10;
            this.lblHeadline.Text = "Payment Table #1";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(458, 280);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(34, 13);
            this.lblTip.TabIndex = 11;
            this.lblTip.Text = "Tip: 0";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Payment method";
            this.columnHeader5.Width = 100;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(544, 280);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(72, 20);
            this.txtTip.TabIndex = 12;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblToPay);
            this.Controls.Add(this.btnEditAmount);
            this.Controls.Add(this.lvPaymentMethod);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblToalAmount);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lvPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPayment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblToalAmount;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.ListView lvPaymentMethod;
        private System.Windows.Forms.Button btnEditAmount;
        private System.Windows.Forms.Label lblToPay;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtTip;
    }
}