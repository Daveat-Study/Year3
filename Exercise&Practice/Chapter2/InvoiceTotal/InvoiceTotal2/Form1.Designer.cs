
namespace InvoiceTotal2
{
    partial class Invoice_Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dis_percent_t = new System.Windows.Forms.Label();
            this.total_t = new System.Windows.Forms.Label();
            this.dis_percent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.dis_amt_t = new System.Windows.Forms.Label();
            this.cal_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sub_total_t
            // 
            this.sub_total_t.AutoSize = true;
            this.sub_total_t.Location = new System.Drawing.Point(25, 24);
            this.sub_total_t.Name = "sub_total_t";
            this.sub_total_t.Size = new System.Drawing.Size(54, 15);
            this.sub_total_t.TabIndex = 0;
            this.sub_total_t.Text = "Sub total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // dis_percent_t
            // 
            this.dis_percent_t.AutoSize = true;
            this.dis_percent_t.Location = new System.Drawing.Point(25, 54);
            this.dis_percent_t.Name = "dis_percent_t";
            this.dis_percent_t.Size = new System.Drawing.Size(97, 15);
            this.dis_percent_t.TabIndex = 2;
            this.dis_percent_t.Text = "Discount Percent";
            // 
            // total_t
            // 
            this.total_t.AutoSize = true;
            this.total_t.Location = new System.Drawing.Point(25, 121);
            this.total_t.Name = "total_t";
            this.total_t.Size = new System.Drawing.Size(32, 15);
            this.total_t.TabIndex = 3;
            this.total_t.Text = "Total";
            // 
            // dis_percent
            // 
            this.dis_percent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dis_percent.Location = new System.Drawing.Point(173, 53);
            this.dis_percent.Name = "dis_percent";
            this.dis_percent.Size = new System.Drawing.Size(100, 26);
            this.dis_percent.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(173, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 5;
            // 
            // total
            // 
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total.Location = new System.Drawing.Point(173, 120);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 27);
            this.total.TabIndex = 6;
            this.total.Click += new System.EventHandler(this.label6_Click);
            // 
            // dis_amt_t
            // 
            this.dis_amt_t.AutoSize = true;
            this.dis_amt_t.Location = new System.Drawing.Point(25, 87);
            this.dis_amt_t.Name = "dis_amt_t";
            this.dis_amt_t.Size = new System.Drawing.Size(101, 15);
            this.dis_amt_t.TabIndex = 7;
            this.dis_amt_t.Text = "Discount Amount";
            // 
            // cal_btn
            // 
            this.cal_btn.Location = new System.Drawing.Point(36, 170);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(75, 23);
            this.cal_btn.TabIndex = 8;
            this.cal_btn.Text = "Calculate";
            this.cal_btn.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(173, 167);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 26);
            this.close_btn.TabIndex = 9;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Invoice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 208);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.dis_amt_t);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dis_percent);
            this.Controls.Add(this.total_t);
            this.Controls.Add(this.dis_percent_t);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sub_total_t);
            this.Name = "Invoice_Form";
            this.Text = "Invoice total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sub_total_t;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dis_percent_t;
        private System.Windows.Forms.Label total_t;
        private System.Windows.Forms.Label dis_percent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label dis_amt_t;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.Button close_btn;
    }
}

