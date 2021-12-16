
namespace shippingAndHandling
{
    partial class frmShippingAndHandling
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
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusType = new System.Windows.Forms.TextBox();
            this.txtShippingCost = new System.Windows.Forms.TextBox();
            this.txtSaleTax = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnCalGrandTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(272, 22);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order total";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Type (P=Preferred N=Non-preferred";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shipping cost (fee for preferred customer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sale tax (7%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Grand total";
            // 
            // txtCusType
            // 
            this.txtCusType.Location = new System.Drawing.Point(272, 71);
            this.txtCusType.Name = "txtCusType";
            this.txtCusType.Size = new System.Drawing.Size(37, 20);
            this.txtCusType.TabIndex = 1;
            // 
            // txtShippingCost
            // 
            this.txtShippingCost.Enabled = false;
            this.txtShippingCost.Location = new System.Drawing.Point(272, 122);
            this.txtShippingCost.Name = "txtShippingCost";
            this.txtShippingCost.ReadOnly = true;
            this.txtShippingCost.Size = new System.Drawing.Size(100, 20);
            this.txtShippingCost.TabIndex = 7;
            this.txtShippingCost.TabStop = false;
            // 
            // txtSaleTax
            // 
            this.txtSaleTax.Enabled = false;
            this.txtSaleTax.Location = new System.Drawing.Point(272, 173);
            this.txtSaleTax.Name = "txtSaleTax";
            this.txtSaleTax.ReadOnly = true;
            this.txtSaleTax.Size = new System.Drawing.Size(100, 20);
            this.txtSaleTax.TabIndex = 8;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(272, 223);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(100, 20);
            this.txtGrandTotal.TabIndex = 9;
            this.txtGrandTotal.TabStop = false;
            // 
            // btnCalGrandTotal
            // 
            this.btnCalGrandTotal.Location = new System.Drawing.Point(76, 273);
            this.btnCalGrandTotal.Name = "btnCalGrandTotal";
            this.btnCalGrandTotal.Size = new System.Drawing.Size(75, 61);
            this.btnCalGrandTotal.TabIndex = 10;
            this.btnCalGrandTotal.TabStop = false;
            this.btnCalGrandTotal.Text = "&Calculate Grand Total";
            this.btnCalGrandTotal.UseVisualStyleBackColor = true;
            this.btnCalGrandTotal.Click += new System.EventHandler(this.btnCalGrandTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(214, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 61);
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmShippingAndHandling
            // 
            this.AcceptButton = this.btnCalGrandTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(384, 369);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalGrandTotal);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtSaleTax);
            this.Controls.Add(this.txtShippingCost);
            this.Controls.Add(this.txtCusType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderTotal);
            this.Name = "frmShippingAndHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shpping and Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusType;
        private System.Windows.Forms.TextBox txtShippingCost;
        private System.Windows.Forms.TextBox txtSaleTax;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btnCalGrandTotal;
        private System.Windows.Forms.Button btnExit;
    }
}

