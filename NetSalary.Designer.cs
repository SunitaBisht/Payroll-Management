namespace Payroll
{
    partial class NetSalary
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
            this.label15 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnokempid = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_net_salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_deduction = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbtndaily = new System.Windows.Forms.RadioButton();
            this.rbtnmonthly = new System.Windows.Forms.RadioButton();
            this.rbtnhourly = new System.Windows.Forms.RadioButton();
            this.rbtnyearly = new System.Windows.Forms.RadioButton();
            this.rbtnweekly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_grossbonus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_incentives = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_basicsalary = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Baskerville Old Face", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(133, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(326, 79);
            this.label15.TabIndex = 21;
            this.label15.Text = "Net Salary";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Gray;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(140, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(73, 32);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Save";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Gray;
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(365, 3);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(73, 32);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 40);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnokempid);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_empid);
            this.panel2.Location = new System.Drawing.Point(12, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 107);
            this.panel2.TabIndex = 20;
            // 
            // btnokempid
            // 
            this.btnokempid.BackColor = System.Drawing.Color.Gray;
            this.btnokempid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnokempid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnokempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnokempid.Location = new System.Drawing.Point(175, 53);
            this.btnokempid.Name = "btnokempid";
            this.btnokempid.Size = new System.Drawing.Size(75, 31);
            this.btnokempid.TabIndex = 2;
            this.btnokempid.Text = "OK";
            this.btnokempid.UseVisualStyleBackColor = false;
            this.btnokempid.Click += new System.EventHandler(this.btnokempid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Employee Id:";
            // 
            // txt_empid
            // 
            this.txt_empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empid.Location = new System.Drawing.Point(6, 55);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(136, 24);
            this.txt_empid.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txt_net_salary);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 163);
            this.panel3.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_net_salary
            // 
            this.txt_net_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_net_salary.Location = new System.Drawing.Point(18, 115);
            this.txt_net_salary.Name = "txt_net_salary";
            this.txt_net_salary.Size = new System.Drawing.Size(182, 29);
            this.txt_net_salary.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Net Salary ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gross Deduction:";
            // 
            // txt_deduction
            // 
            this.txt_deduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deduction.Location = new System.Drawing.Point(149, 116);
            this.txt_deduction.Name = "txt_deduction";
            this.txt_deduction.Size = new System.Drawing.Size(136, 24);
            this.txt_deduction.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.rbtndaily);
            this.panel6.Controls.Add(this.rbtnmonthly);
            this.panel6.Controls.Add(this.rbtnhourly);
            this.panel6.Controls.Add(this.rbtnyearly);
            this.panel6.Controls.Add(this.rbtnweekly);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txt_grossbonus);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txt_incentives);
            this.panel6.Controls.Add(this.txt_deduction);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_basicsalary);
            this.panel6.Location = new System.Drawing.Point(288, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 285);
            this.panel6.TabIndex = 27;
            // 
            // rbtndaily
            // 
            this.rbtndaily.AutoSize = true;
            this.rbtndaily.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtndaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtndaily.Location = new System.Drawing.Point(231, 195);
            this.rbtndaily.Name = "rbtndaily";
            this.rbtndaily.Size = new System.Drawing.Size(63, 20);
            this.rbtndaily.TabIndex = 16;
            this.rbtndaily.TabStop = true;
            this.rbtndaily.Text = "Daily";
            this.rbtndaily.UseVisualStyleBackColor = true;
            // 
            // rbtnmonthly
            // 
            this.rbtnmonthly.AutoSize = true;
            this.rbtnmonthly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtnmonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnmonthly.Location = new System.Drawing.Point(149, 195);
            this.rbtnmonthly.Name = "rbtnmonthly";
            this.rbtnmonthly.Size = new System.Drawing.Size(81, 20);
            this.rbtnmonthly.TabIndex = 3;
            this.rbtnmonthly.TabStop = true;
            this.rbtnmonthly.Text = "Monthly";
            this.rbtnmonthly.UseVisualStyleBackColor = true;
            // 
            // rbtnhourly
            // 
            this.rbtnhourly.AutoSize = true;
            this.rbtnhourly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtnhourly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnhourly.Location = new System.Drawing.Point(231, 228);
            this.rbtnhourly.Name = "rbtnhourly";
            this.rbtnhourly.Size = new System.Drawing.Size(72, 20);
            this.rbtnhourly.TabIndex = 13;
            this.rbtnhourly.TabStop = true;
            this.rbtnhourly.Text = "Hourly";
            this.rbtnhourly.UseVisualStyleBackColor = true;
            // 
            // rbtnyearly
            // 
            this.rbtnyearly.AutoSize = true;
            this.rbtnyearly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtnyearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnyearly.Location = new System.Drawing.Point(149, 254);
            this.rbtnyearly.Name = "rbtnyearly";
            this.rbtnyearly.Size = new System.Drawing.Size(70, 20);
            this.rbtnyearly.TabIndex = 14;
            this.rbtnyearly.TabStop = true;
            this.rbtnyearly.Text = "Yearly";
            this.rbtnyearly.UseVisualStyleBackColor = true;
            // 
            // rbtnweekly
            // 
            this.rbtnweekly.AutoSize = true;
            this.rbtnweekly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtnweekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnweekly.Location = new System.Drawing.Point(149, 228);
            this.rbtnweekly.Name = "rbtnweekly";
            this.rbtnweekly.Size = new System.Drawing.Size(76, 20);
            this.rbtnweekly.TabIndex = 15;
            this.rbtnweekly.TabStop = true;
            this.rbtnweekly.Text = "Weekly";
            this.rbtnweekly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bonus Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gross Bonus :";
            // 
            // txt_grossbonus
            // 
            this.txt_grossbonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grossbonus.Location = new System.Drawing.Point(149, 66);
            this.txt_grossbonus.Name = "txt_grossbonus";
            this.txt_grossbonus.Size = new System.Drawing.Size(136, 24);
            this.txt_grossbonus.TabIndex = 10;
            this.txt_grossbonus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gross Incentives :";
            // 
            // txt_incentives
            // 
            this.txt_incentives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_incentives.Location = new System.Drawing.Point(149, 160);
            this.txt_incentives.Name = "txt_incentives";
            this.txt_incentives.Size = new System.Drawing.Size(136, 24);
            this.txt_incentives.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Basic Salary:";
            // 
            // txt_basicsalary
            // 
            this.txt_basicsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_basicsalary.Location = new System.Drawing.Point(149, 16);
            this.txt_basicsalary.Name = "txt_basicsalary";
            this.txt_basicsalary.Size = new System.Drawing.Size(136, 24);
            this.txt_basicsalary.TabIndex = 1;
            // 
            // NetSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 431);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NetSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Salary";
            this.Load += new System.EventHandler(this.NetSalary_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnokempid;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_net_salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_deduction;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_grossbonus;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_incentives;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_basicsalary;
        private System.Windows.Forms.RadioButton rbtndaily;
        private System.Windows.Forms.RadioButton rbtnmonthly;
        private System.Windows.Forms.RadioButton rbtnhourly;
        private System.Windows.Forms.RadioButton rbtnyearly;
        private System.Windows.Forms.RadioButton rbtnweekly;
        private System.Windows.Forms.Label label2;
    }
}