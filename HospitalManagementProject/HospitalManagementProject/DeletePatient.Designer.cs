namespace HospitalManagementProject
{
    partial class DeletePatient
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
            this.dataGridViewPat = new System.Windows.Forms.DataGridView();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelDeletePatient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPat
            // 
            this.dataGridViewPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPat.Location = new System.Drawing.Point(163, 60);
            this.dataGridViewPat.Name = "dataGridViewPat";
            this.dataGridViewPat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPat.Size = new System.Drawing.Size(419, 351);
            this.dataGridViewPat.TabIndex = 0;
            this.dataGridViewPat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(556, 417);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 1;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(116, 417);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelDeletePatient
            // 
            this.labelDeletePatient.AutoSize = true;
            this.labelDeletePatient.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeletePatient.Location = new System.Drawing.Point(296, 19);
            this.labelDeletePatient.Name = "labelDeletePatient";
            this.labelDeletePatient.Size = new System.Drawing.Size(172, 27);
            this.labelDeletePatient.TabIndex = 3;
            this.labelDeletePatient.Text = "DeletePatient";
            // 
            // DeletePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(740, 504);
            this.Controls.Add(this.labelDeletePatient);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.dataGridViewPat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeletePatient";
            this.Text = "DeletePatient";
            this.Load += new System.EventHandler(this.DeletePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPat;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelDeletePatient;
    }
}