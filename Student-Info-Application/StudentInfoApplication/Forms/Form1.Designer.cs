namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studID = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listStudentID = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listFirstname = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listLastName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name *";
            // 
            // studID
            // 
            this.studID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studID.Location = new System.Drawing.Point(17, 41);
            this.studID.Name = "studID";
            this.studID.Size = new System.Drawing.Size(220, 30);
            this.studID.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(286, 41);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(220, 30);
            this.lastName.TabIndex = 4;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(552, 41);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(220, 30);
            this.firstName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(665, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listStudentID
            // 
            this.listStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStudentID.FormattingEnabled = true;
            this.listStudentID.ItemHeight = 31;
            this.listStudentID.Location = new System.Drawing.Point(17, 196);
            this.listStudentID.Name = "listStudentID";
            this.listStudentID.Size = new System.Drawing.Size(220, 221);
            this.listStudentID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student ID List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name List";
            // 
            // listFirstname
            // 
            this.listFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFirstname.FormattingEnabled = true;
            this.listFirstname.ItemHeight = 31;
            this.listFirstname.Location = new System.Drawing.Point(286, 196);
            this.listFirstname.Name = "listFirstname";
            this.listFirstname.Size = new System.Drawing.Size(220, 221);
            this.listFirstname.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Name List";
            // 
            // listLastName
            // 
            this.listLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLastName.FormattingEnabled = true;
            this.listLastName.ItemHeight = 31;
            this.listLastName.Location = new System.Drawing.Point(552, 196);
            this.listLastName.Name = "listLastName";
            this.listLastName.Size = new System.Drawing.Size(220, 221);
            this.listLastName.TabIndex = 11;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listFirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listStudentID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.studID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentInfo";
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studID;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listFirstname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listLastName;
    }
}

