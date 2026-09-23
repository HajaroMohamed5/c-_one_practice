namespace asssignment1
{
    partial class lbname
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(442, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(312, 20);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(442, 100);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(312, 20);
            this.txtstudentid.TabIndex = 1;
            this.txtstudentid.TextChanged += new System.EventHandler(this.txtstudentid_TextChanged);
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(442, 144);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(312, 20);
            this.txtdepartment.TabIndex = 2;
            this.txtdepartment.TextChanged += new System.EventHandler(this.txtdepartment_TextChanged);
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(442, 185);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(312, 20);
            this.txtsemester.TabIndex = 3;
            this.txtsemester.TextChanged += new System.EventHandler(this.txtsemester_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(28, 48);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(119, 13);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Enter the Student name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(28, 82);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(104, 13);
            this.lblstudentid.TabIndex = 5;
            this.lblstudentid.Text = "Enter the Student ID";
            this.lblstudentid.Click += new System.EventHandler(this.lblstudentid_Click);
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(28, 126);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(106, 13);
            this.lbldepartment.TabIndex = 6;
            this.lbldepartment.Text = "Enter the department";
            this.lbldepartment.Click += new System.EventHandler(this.lbldepartment_Click);
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(31, 175);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(97, 13);
            this.lblsemester.TabIndex = 7;
            this.lblsemester.Text = "Enter the Semester";
            this.lblsemester.Click += new System.EventHandler(this.lblsemester_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(96, 356);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(154, 30);
            this.btnshowinfo.TabIndex = 8;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnsshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(382, 356);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 30);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(577, 356);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 30);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(147, 277);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(431, 46);
            this.lbloutput.TabIndex = 12;
            this.lbloutput.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(256, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student Information";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Name = "lbname";
            this.Text = "assignment1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label label1;
    }
}

