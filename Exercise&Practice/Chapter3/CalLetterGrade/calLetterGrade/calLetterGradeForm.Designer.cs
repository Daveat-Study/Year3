
namespace calLetterGrade
{
    partial class calculateLetterGrade
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
            this.txtNumericGrade = new System.Windows.Forms.TextBox();
            this.numbericGrade = new System.Windows.Forms.Label();
            this.btnCalLetterGrade = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumericGrade
            // 
            this.txtNumericGrade.Location = new System.Drawing.Point(274, 37);
            this.txtNumericGrade.Name = "txtNumericGrade";
            this.txtNumericGrade.Size = new System.Drawing.Size(100, 20);
            this.txtNumericGrade.TabIndex = 0;
            // 
            // numbericGrade
            // 
            this.numbericGrade.AutoSize = true;
            this.numbericGrade.Location = new System.Drawing.Point(78, 40);
            this.numbericGrade.Name = "numbericGrade";
            this.numbericGrade.Size = new System.Drawing.Size(78, 13);
            this.numbericGrade.TabIndex = 2;
            this.numbericGrade.Text = "Numeric Grade";
            // 
            // btnCalLetterGrade
            // 
            this.btnCalLetterGrade.Location = new System.Drawing.Point(81, 204);
            this.btnCalLetterGrade.Name = "btnCalLetterGrade";
            this.btnCalLetterGrade.Size = new System.Drawing.Size(78, 62);
            this.btnCalLetterGrade.TabIndex = 3;
            this.btnCalLetterGrade.TabStop = false;
            this.btnCalLetterGrade.Text = "&Calculate Letter Grade";
            this.btnCalLetterGrade.UseVisualStyleBackColor = true;
            this.btnCalLetterGrade.Click += new System.EventHandler(this.btnCalLetterGrade_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(274, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Letter grade";
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetterGrade.Location = new System.Drawing.Point(271, 120);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(103, 20);
            this.lblLetterGrade.TabIndex = 1;
            // 
            // calculateLetterGrade
            // 
            this.AcceptButton = this.btnCalLetterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(441, 300);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalLetterGrade);
            this.Controls.Add(this.numbericGrade);
            this.Controls.Add(this.txtNumericGrade);
            this.Name = "calculateLetterGrade";
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumericGrade;
        private System.Windows.Forms.Label numbericGrade;
        private System.Windows.Forms.Button btnCalLetterGrade;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLetterGrade;
    }
}

