namespace InternRegistrationProject
{
    partial class List_Result
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
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.ListResult_Back = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.passedRadio = new System.Windows.Forms.RadioButton();
            this.failedRadio = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // resultGrid
            // 
            this.resultGrid.BackgroundColor = System.Drawing.Color.White;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Location = new System.Drawing.Point(12, 222);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.RowHeadersWidth = 62;
            this.resultGrid.RowTemplate.Height = 28;
            this.resultGrid.Size = new System.Drawing.Size(1822, 463);
            this.resultGrid.TabIndex = 0;
            this.resultGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultGrid_CellContentClick);
            // 
            // ListResult_Back
            // 
            this.ListResult_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ListResult_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListResult_Back.Location = new System.Drawing.Point(26, 26);
            this.ListResult_Back.Name = "ListResult_Back";
            this.ListResult_Back.Size = new System.Drawing.Size(173, 55);
            this.ListResult_Back.TabIndex = 1;
            this.ListResult_Back.Text = "Back";
            this.ListResult_Back.UseVisualStyleBackColor = false;
            this.ListResult_Back.Click += new System.EventHandler(this.ListResult_Back_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search_button.Location = new System.Drawing.Point(791, 117);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(259, 39);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // passedRadio
            // 
            this.passedRadio.AutoSize = true;
            this.passedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passedRadio.Location = new System.Drawing.Point(791, 175);
            this.passedRadio.Name = "passedRadio";
            this.passedRadio.Size = new System.Drawing.Size(93, 24);
            this.passedRadio.TabIndex = 3;
            this.passedRadio.TabStop = true;
            this.passedRadio.Text = "Passed";
            this.passedRadio.UseVisualStyleBackColor = true;
            // 
            // failedRadio
            // 
            this.failedRadio.AutoSize = true;
            this.failedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.failedRadio.Location = new System.Drawing.Point(966, 175);
            this.failedRadio.Name = "failedRadio";
            this.failedRadio.Size = new System.Drawing.Size(83, 24);
            this.failedRadio.TabIndex = 4;
            this.failedRadio.TabStop = true;
            this.failedRadio.Text = "Failed";
            this.failedRadio.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(791, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 26);
            this.txtSearch.TabIndex = 5;
            // 
            // List_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1843, 696);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.failedRadio);
            this.Controls.Add(this.passedRadio);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.ListResult_Back);
            this.Controls.Add(this.resultGrid);
            this.Name = "List_Result";
            this.Text = "List_Result";
            this.Load += new System.EventHandler(this.List_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Button ListResult_Back;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.RadioButton passedRadio;
        private System.Windows.Forms.RadioButton failedRadio;
        private System.Windows.Forms.TextBox txtSearch;
    }
}