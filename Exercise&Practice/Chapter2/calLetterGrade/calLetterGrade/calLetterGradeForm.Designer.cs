
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numbericGrade = new System.Windows.Forms.Label();
            this.calLetterGrade = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
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
            // calLetterGrade
            // 
            this.calLetterGrade.Location = new System.Drawing.Point(81, 204);
            this.calLetterGrade.Name = "calLetterGrade";
            this.calLetterGrade.Size = new System.Drawing.Size(78, 62);
            this.calLetterGrade.TabIndex = 3;
            this.calLetterGrade.TabStop = false;
            this.calLetterGrade.Text = "&Calculate Letter Grade";
            this.calLetterGrade.UseVisualStyleBackColor = true;
            this.calLetterGrade.Click += new System.EventHandler(this.calLetter_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(274, 204);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(78, 62);
            this.exit.TabIndex = 4;
            this.exit.TabStop = false;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
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
            // calculateLetterGrade
            // 
            this.AcceptButton = this.calLetterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(441, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calLetterGrade);
            this.Controls.Add(this.numbericGrade);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "calculateLetterGrade";
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label numbericGrade;
        private System.Windows.Forms.Button calLetterGrade;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
    }
}

