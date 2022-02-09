
namespace InvoiceTotal
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sub_total_t = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.dis_percent_t = new System.Windows.Forms.Label();
            this.total_t = new System.Windows.Forms.Label();
            this.dis_amt_t = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sub_total_t
            // 
            this.sub_total_t.AutoSize = true;
            this.sub_total_t.Location = new System.Drawing.Point(25, 24);
            this.sub_total_t.Name = "sub_total_t";
            this.sub_total_t.Size = new System.Drawing.Size(51, 15);
            this.sub_total_t.TabIndex = 0;
            this.sub_total_t.Text = "&Subtotal";
            this.sub_total_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(173, 21);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 1;
            // 
            // dis_percent_t
            // 
            this.dis_percent_t.AutoSize = true;
            this.dis_percent_t.Location = new System.Drawing.Point(25, 54);
            this.dis_percent_t.Name = "dis_percent_t";
            this.dis_percent_t.Size = new System.Drawing.Size(100, 15);
            this.dis_percent_t.TabIndex = 2;
            this.dis_percent_t.Text = "Discount percent:";
            this.dis_percent_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total_t
            // 
            this.total_t.AutoSize = true;
            this.total_t.Location = new System.Drawing.Point(25, 121);
            this.total_t.Name = "total_t";
            this.total_t.Size = new System.Drawing.Size(35, 15);
            this.total_t.TabIndex = 3;
            this.total_t.Text = "Total:";
            this.total_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dis_amt_t
            // 
            this.dis_amt_t.AutoSize = true;
            this.dis_amt_t.Location = new System.Drawing.Point(25, 87);
            this.dis_amt_t.Name = "dis_amt_t";
            this.dis_amt_t.Size = new System.Drawing.Size(102, 15);
            this.dis_amt_t.TabIndex = 7;
            this.dis_amt_t.Text = "Discount amount:";
            this.dis_amt_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(196, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 26);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(173, 54);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 23);
            this.txtDiscountPercent.TabIndex = 8;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(173, 87);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 23);
            this.txtDiscountAmount.TabIndex = 9;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(173, 121);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(103, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 26);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(293, 208);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dis_amt_t);
            this.Controls.Add(this.total_t);
            this.Controls.Add(this.dis_percent_t);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.sub_total_t);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sub_total_t;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label dis_percent_t;
        private System.Windows.Forms.Label total_t;
        private System.Windows.Forms.Label dis_amt_t;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}

