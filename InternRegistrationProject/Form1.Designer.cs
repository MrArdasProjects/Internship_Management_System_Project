namespace InternRegistrationProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddInternPageButton = new System.Windows.Forms.Button();
            this.addDepartmentPageButton = new System.Windows.Forms.Button();
            this.NoteAddingPageButton = new System.Windows.Forms.Button();
            this.listResultPageButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddInternPageButton
            // 
            this.AddInternPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddInternPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddInternPageButton.ForeColor = System.Drawing.Color.Black;
            this.AddInternPageButton.Location = new System.Drawing.Point(258, 106);
            this.AddInternPageButton.Name = "AddInternPageButton";
            this.AddInternPageButton.Size = new System.Drawing.Size(250, 183);
            this.AddInternPageButton.TabIndex = 0;
            this.AddInternPageButton.Text = "Intern Adding Page";
            this.AddInternPageButton.UseVisualStyleBackColor = false;
            this.AddInternPageButton.Click += new System.EventHandler(this.AddInternPageButton_Click);
            // 
            // addDepartmentPageButton
            // 
            this.addDepartmentPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addDepartmentPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addDepartmentPageButton.Location = new System.Drawing.Point(585, 106);
            this.addDepartmentPageButton.Name = "addDepartmentPageButton";
            this.addDepartmentPageButton.Size = new System.Drawing.Size(250, 183);
            this.addDepartmentPageButton.TabIndex = 1;
            this.addDepartmentPageButton.Text = "Department Adding Page";
            this.addDepartmentPageButton.UseVisualStyleBackColor = false;
            this.addDepartmentPageButton.Click += new System.EventHandler(this.addDepartmentPageButton_Click);
            // 
            // NoteAddingPageButton
            // 
            this.NoteAddingPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NoteAddingPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoteAddingPageButton.Location = new System.Drawing.Point(258, 333);
            this.NoteAddingPageButton.Name = "NoteAddingPageButton";
            this.NoteAddingPageButton.Size = new System.Drawing.Size(250, 183);
            this.NoteAddingPageButton.TabIndex = 2;
            this.NoteAddingPageButton.Text = "Note Adding Page For Intern";
            this.NoteAddingPageButton.UseVisualStyleBackColor = false;
            this.NoteAddingPageButton.Click += new System.EventHandler(this.NoteAddingPageButton_Click);
            // 
            // listResultPageButton
            // 
            this.listResultPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listResultPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listResultPageButton.Location = new System.Drawing.Point(585, 333);
            this.listResultPageButton.Name = "listResultPageButton";
            this.listResultPageButton.Size = new System.Drawing.Size(250, 183);
            this.listResultPageButton.TabIndex = 3;
            this.listResultPageButton.Text = "List Results";
            this.listResultPageButton.UseVisualStyleBackColor = false;
            this.listResultPageButton.Click += new System.EventHandler(this.listResultPageButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.Location = new System.Drawing.Point(258, 548);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(577, 67);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1155, 714);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.listResultPageButton);
            this.Controls.Add(this.NoteAddingPageButton);
            this.Controls.Add(this.addDepartmentPageButton);
            this.Controls.Add(this.AddInternPageButton);
            this.Name = "Form1";
            this.Text = "Internship Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddInternPageButton;
        private System.Windows.Forms.Button addDepartmentPageButton;
        private System.Windows.Forms.Button NoteAddingPageButton;
        private System.Windows.Forms.Button listResultPageButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

