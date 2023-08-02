namespace EmployeeFormApplication
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
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textpf = new System.Windows.Forms.TextBox();
            this.textda = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.texthra = new System.Windows.Forms.TextBox();
            this.textta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combodept = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textgs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(148, 59);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(200, 22);
            this.textId.TabIndex = 0;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(148, 217);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(200, 22);
            this.textSalary.TabIndex = 10;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(148, 109);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(200, 22);
            this.textFirstName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(148, 163);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(200, 22);
            this.textLastName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "DA";
            // 
            // textpf
            // 
            this.textpf.Enabled = false;
            this.textpf.Location = new System.Drawing.Point(148, 439);
            this.textpf.Name = "textpf";
            this.textpf.Size = new System.Drawing.Size(200, 22);
            this.textpf.TabIndex = 20;
            // 
            // textda
            // 
            this.textda.Enabled = false;
            this.textda.Location = new System.Drawing.Point(148, 383);
            this.textda.Name = "textda";
            this.textda.Size = new System.Drawing.Size(200, 22);
            this.textda.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 634);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "HRA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "TA";
            // 
            // texthra
            // 
            this.texthra.Enabled = false;
            this.texthra.Location = new System.Drawing.Point(148, 273);
            this.texthra.Name = "texthra";
            this.texthra.Size = new System.Drawing.Size(200, 22);
            this.texthra.TabIndex = 25;
            // 
            // textta
            // 
            this.textta.Enabled = false;
            this.textta.Location = new System.Drawing.Point(148, 324);
            this.textta.Name = "textta";
            this.textta.Size = new System.Drawing.Size(200, 22);
            this.textta.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 634);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Joining Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Department";
            // 
            // combodept
            // 
            this.combodept.FormattingEnabled = true;
            this.combodept.Location = new System.Drawing.Point(148, 555);
            this.combodept.Name = "combodept";
            this.combodept.Size = new System.Drawing.Size(200, 24);
            this.combodept.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "PF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Gross Salary";
            // 
            // textgs
            // 
            this.textgs.Enabled = false;
            this.textgs.Location = new System.Drawing.Point(148, 496);
            this.textgs.Name = "textgs";
            this.textgs.Size = new System.Drawing.Size(200, 22);
            this.textgs.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 56);
            this.button1.TabIndex = 33;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Salary";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(529, 220);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(94, 52);
            this.Display.TabIndex = 35;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 783);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textgs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combodept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textta);
            this.Controls.Add(this.texthra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textda);
            this.Controls.Add(this.textpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EmployeeLoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textpf;
        private System.Windows.Forms.TextBox textda;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox texthra;
        private System.Windows.Forms.TextBox textta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combodept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textgs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Display;
    }
}

