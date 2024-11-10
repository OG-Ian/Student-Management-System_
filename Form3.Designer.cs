namespace Student_Management_System_
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 334);
            this.dataGridView1.TabIndex = 19;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(777, 249);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(210, 22);
            this.txtCourse.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "COURSE:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(777, 211);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 22);
            this.txtName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "NAME:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(777, 156);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(210, 22);
            this.txtAge.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "AGE:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(777, 118);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(210, 22);
            this.txtStudentID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "STUDENT ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateStudent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStudent.Location = new System.Drawing.Point(834, 314);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(179, 38);
            this.btnUpdateStudent.TabIndex = 29;
            this.btnUpdateStudent.Text = "UPDATE";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.Location = new System.Drawing.Point(624, 314);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 38);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 553);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "UPDATE STUDENT FORM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnBack;
    }
}