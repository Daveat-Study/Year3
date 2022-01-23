namespace Payment
{
    partial class frmPayment
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
            this.cmbBoxSelectMonth = new System.Windows.Forms.ComboBox();
            this.grpBilling = new System.Windows.Forms.GroupBox();
            this.rdBtnBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdBtnCeditCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBxCeditCardType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxSelectYear = new System.Windows.Forms.ComboBox();
            this.chkBoxSetDefaultBillingMethod = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxSelectMonth
            // 
            this.cmbBoxSelectMonth.FormattingEnabled = true;
            this.cmbBoxSelectMonth.Location = new System.Drawing.Point(133, 233);
            this.cmbBoxSelectMonth.Name = "cmbBoxSelectMonth";
            this.cmbBoxSelectMonth.Size = new System.Drawing.Size(149, 21);
            this.cmbBoxSelectMonth.TabIndex = 2;
            this.cmbBoxSelectMonth.Text = "Select a month";
            // 
            // grpBilling
            // 
            this.grpBilling.Controls.Add(this.rdBtnBillCustomer);
            this.grpBilling.Controls.Add(this.rdBtnCeditCard);
            this.grpBilling.Location = new System.Drawing.Point(27, 25);
            this.grpBilling.Name = "grpBilling";
            this.grpBilling.Size = new System.Drawing.Size(393, 70);
            this.grpBilling.TabIndex = 7;
            this.grpBilling.TabStop = false;
            this.grpBilling.Text = "Billing";
            // 
            // rdBtnBillCustomer
            // 
            this.rdBtnBillCustomer.AutoSize = true;
            this.rdBtnBillCustomer.Location = new System.Drawing.Point(261, 29);
            this.rdBtnBillCustomer.Name = "rdBtnBillCustomer";
            this.rdBtnBillCustomer.Size = new System.Drawing.Size(84, 17);
            this.rdBtnBillCustomer.TabIndex = 9;
            this.rdBtnBillCustomer.TabStop = true;
            this.rdBtnBillCustomer.Text = "Bill customer";
            this.rdBtnBillCustomer.UseVisualStyleBackColor = true;
            this.rdBtnBillCustomer.CheckedChanged += new System.EventHandler(this.rdBtnBillCustomer_CheckedChanged);
            // 
            // rdBtnCeditCard
            // 
            this.rdBtnCeditCard.AutoSize = true;
            this.rdBtnCeditCard.Location = new System.Drawing.Point(65, 29);
            this.rdBtnCeditCard.Name = "rdBtnCeditCard";
            this.rdBtnCeditCard.Size = new System.Drawing.Size(73, 17);
            this.rdBtnCeditCard.TabIndex = 8;
            this.rdBtnCeditCard.TabStop = true;
            this.rdBtnCeditCard.Text = "Cedit card";
            this.rdBtnCeditCard.UseVisualStyleBackColor = true;
            this.rdBtnCeditCard.CheckedChanged += new System.EventHandler(this.rdBtnCeditCard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 117);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Credit card type:";
            // 
            // lstBxCeditCardType
            // 
            this.lstBxCeditCardType.FormattingEnabled = true;
            this.lstBxCeditCardType.Items.AddRange(new object[] {
            "American Express",
            "Matercard",
            "Visa"});
            this.lstBxCeditCardType.Location = new System.Drawing.Point(133, 117);
            this.lstBxCeditCardType.Name = "lstBxCeditCardType";
            this.lstBxCeditCardType.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBxCeditCardType.Size = new System.Drawing.Size(287, 56);
            this.lstBxCeditCardType.Sorted = true;
            this.lstBxCeditCardType.TabIndex = 0;
            this.lstBxCeditCardType.SelectedIndexChanged += new System.EventHandler(this.lstBxCeditCardType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 196);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Card number:";
            // 
            // txtBoxCardNumber
            // 
            this.txtBoxCardNumber.Location = new System.Drawing.Point(133, 193);
            this.txtBoxCardNumber.Name = "txtBoxCardNumber";
            this.txtBoxCardNumber.Size = new System.Drawing.Size(287, 20);
            this.txtBoxCardNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 241);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Expiration date:";
            // 
            // cmbBoxSelectYear
            // 
            this.cmbBoxSelectYear.FormattingEnabled = true;
            this.cmbBoxSelectYear.Location = new System.Drawing.Point(288, 233);
            this.cmbBoxSelectYear.Name = "cmbBoxSelectYear";
            this.cmbBoxSelectYear.Size = new System.Drawing.Size(132, 21);
            this.cmbBoxSelectYear.TabIndex = 3;
            this.cmbBoxSelectYear.Text = "Select a year";
            // 
            // chkBoxSetDefaultBillingMethod
            // 
            this.chkBoxSetDefaultBillingMethod.AutoSize = true;
            this.chkBoxSetDefaultBillingMethod.Location = new System.Drawing.Point(24, 289);
            this.chkBoxSetDefaultBillingMethod.Name = "chkBoxSetDefaultBillingMethod";
            this.chkBoxSetDefaultBillingMethod.Size = new System.Drawing.Size(158, 17);
            this.chkBoxSetDefaultBillingMethod.TabIndex = 4;
            this.chkBoxSetDefaultBillingMethod.Text = "Set as default billing method";
            this.chkBoxSetDefaultBillingMethod.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(208, 317);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(93, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(442, 362);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkBoxSetDefaultBillingMethod);
            this.Controls.Add(this.cmbBoxSelectYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBxCeditCardType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBilling);
            this.Controls.Add(this.cmbBoxSelectMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.grpBilling.ResumeLayout(false);
            this.grpBilling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxSelectMonth;
        private System.Windows.Forms.GroupBox grpBilling;
        private System.Windows.Forms.RadioButton rdBtnBillCustomer;
        private System.Windows.Forms.RadioButton rdBtnCeditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBxCeditCardType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxSelectYear;
        private System.Windows.Forms.CheckBox chkBoxSetDefaultBillingMethod;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

