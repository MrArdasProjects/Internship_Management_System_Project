namespace InternRegistrationProject
{
    partial class Note_Adding
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
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.Note_Add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotePage_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deptComboBox
            // 
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Location = new System.Drawing.Point(272, 119);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(372, 28);
            this.deptComboBox.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(272, 183);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(372, 26);
            this.txtPhone.TabIndex = 1;
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(272, 246);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(372, 26);
            this.txtExam1.TabIndex = 2;
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(272, 308);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(372, 26);
            this.txtExam2.TabIndex = 3;
            // 
            // Note_Add_Button
            // 
            this.Note_Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Note_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Note_Add_Button.Location = new System.Drawing.Point(461, 366);
            this.Note_Add_Button.Name = "Note_Add_Button";
            this.Note_Add_Button.Size = new System.Drawing.Size(183, 52);
            this.Note_Add_Button.TabIndex = 4;
            this.Note_Add_Button.Text = "Add";
            this.Note_Add_Button.UseVisualStyleBackColor = false;
            this.Note_Add_Button.Click += new System.EventHandler(this.Note_Add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(140, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oral Exam :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(140, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Written Exam :";
            // 
            // NotePage_Back
            // 
            this.NotePage_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NotePage_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotePage_Back.Location = new System.Drawing.Point(34, 25);
            this.NotePage_Back.Name = "NotePage_Back";
            this.NotePage_Back.Size = new System.Drawing.Size(147, 57);
            this.NotePage_Back.TabIndex = 9;
            this.NotePage_Back.Text = "Back";
            this.NotePage_Back.UseVisualStyleBackColor = false;
            this.NotePage_Back.Click += new System.EventHandler(this.NotePage_Back_Click);
            // 
            // Note_Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(793, 581);
            this.Controls.Add(this.NotePage_Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Note_Add_Button);
            this.Controls.Add(this.txtExam2);
            this.Controls.Add(this.txtExam1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.deptComboBox);
            this.Name = "Note_Adding";
            this.Text = "Note_Adding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.Button Note_Add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NotePage_Back;
    }
}