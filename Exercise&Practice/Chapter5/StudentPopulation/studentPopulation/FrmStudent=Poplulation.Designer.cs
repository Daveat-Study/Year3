
namespace studentPopulation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfStudentsToday = new System.Windows.Forms.TextBox();
            this.btnProStudentPop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAnlGrowthRate = new System.Windows.Forms.TextBox();
            this.txtNumOfYear = new System.Windows.Forms.TextBox();
            this.txtNumberOfProjectedStudents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Student Today";
            // 
            // txtNumberOfStudentsToday
            // 
            this.txtNumberOfStudentsToday.Location = new System.Drawing.Point(244, 32);
            this.txtNumberOfStudentsToday.Name = "txtNumberOfStudentsToday";
            this.txtNumberOfStudentsToday.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfStudentsToday.TabIndex = 1;
            this.txtNumberOfStudentsToday.TextChanged += new System.EventHandler(this.txtNumberOfStudentsToday_TextChanged);
            // 
            // btnProStudentPop
            // 
            this.btnProStudentPop.Location = new System.Drawing.Point(64, 222);
            this.btnProStudentPop.Name = "btnProStudentPop";
            this.btnProStudentPop.Size = new System.Drawing.Size(81, 69);
            this.btnProStudentPop.TabIndex = 2;
            this.btnProStudentPop.TabStop = false;
            this.btnProStudentPop.Text = "&Project Student Population";
            this.btnProStudentPop.UseVisualStyleBackColor = true;
            this.btnProStudentPop.Click += new System.EventHandler(this.btnProStudentPop_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(244, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 69);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAnlGrowthRate
            // 
            this.txtAnlGrowthRate.Location = new System.Drawing.Point(244, 81);
            this.txtAnlGrowthRate.Name = "txtAnlGrowthRate";
            this.txtAnlGrowthRate.Size = new System.Drawing.Size(100, 20);
            this.txtAnlGrowthRate.TabIndex = 2;
            // 
            // txtNumOfYear
            // 
            this.txtNumOfYear.Location = new System.Drawing.Point(244, 126);
            this.txtNumOfYear.Name = "txtNumOfYear";
            this.txtNumOfYear.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfYear.TabIndex = 3;
            // 
            // txtNumberOfProjectedStudents
            // 
            this.txtNumberOfProjectedStudents.Enabled = false;
            this.txtNumberOfProjectedStudents.Location = new System.Drawing.Point(244, 172);
            this.txtNumberOfProjectedStudents.Name = "txtNumberOfProjectedStudents";
            this.txtNumberOfProjectedStudents.ReadOnly = true;
            this.txtNumberOfProjectedStudents.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfProjectedStudents.TabIndex = 6;
            this.txtNumberOfProjectedStudents.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Annaul growth rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Projected number of students";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnProStudentPop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(393, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfProjectedStudents);
            this.Controls.Add(this.txtNumOfYear);
            this.Controls.Add(this.txtAnlGrowthRate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProStudentPop);
            this.Controls.Add(this.txtNumberOfStudentsToday);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Poplulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfStudentsToday;
        private System.Windows.Forms.Button btnProStudentPop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAnlGrowthRate;
        private System.Windows.Forms.TextBox txtNumOfYear;
        private System.Windows.Forms.TextBox txtNumberOfProjectedStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

