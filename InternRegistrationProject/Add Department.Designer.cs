namespace InternRegistrationProject
{
    partial class Add_Department
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
            this.deptDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Department_Add = new System.Windows.Forms.Button();
            this.Department_Back = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deptDataGrid
            // 
            this.deptDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.deptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptDataGrid.Location = new System.Drawing.Point(12, 267);
            this.deptDataGrid.Name = "deptDataGrid";
            this.deptDataGrid.RowHeadersWidth = 62;
            this.deptDataGrid.RowTemplate.Height = 28;
            this.deptDataGrid.Size = new System.Drawing.Size(1131, 355);
            this.deptDataGrid.TabIndex = 0;
            this.deptDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deptDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(243, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department Name :";
            // 
            // Department_Add
            // 
            this.Department_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Department_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Department_Add.Location = new System.Drawing.Point(414, 150);
            this.Department_Add.Name = "Department_Add";
            this.Department_Add.Size = new System.Drawing.Size(232, 50);
            this.Department_Add.TabIndex = 3;
            this.Department_Add.Text = "Add";
            this.Department_Add.UseVisualStyleBackColor = false;
            this.Department_Add.Click += new System.EventHandler(this.Department_Add_Click);
            // 
            // Department_Back
            // 
            this.Department_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Department_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Department_Back.Location = new System.Drawing.Point(12, 12);
            this.Department_Back.Name = "Department_Back";
            this.Department_Back.Size = new System.Drawing.Size(148, 57);
            this.Department_Back.TabIndex = 5;
            this.Department_Back.Text = "Back";
            this.Department_Back.UseVisualStyleBackColor = false;
            this.Department_Back.Click += new System.EventHandler(this.Department_Back_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(414, 91);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(232, 26);
            this.txtDept.TabIndex = 6;
            // 
            // Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1155, 644);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.Department_Back);
            this.Controls.Add(this.Department_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deptDataGrid);
            this.Name = "Add_Department";
            this.Text = "Add_Department";
            this.Load += new System.EventHandler(this.Add_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView deptDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Department_Add;
        private System.Windows.Forms.Button Department_Back;
        private System.Windows.Forms.TextBox txtDept;
    }
}