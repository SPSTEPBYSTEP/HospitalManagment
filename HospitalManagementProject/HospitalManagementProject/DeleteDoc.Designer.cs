namespace HospitalManagementProject
{
    partial class DeleteDoc
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.dataGridViewDocDel = new System.Windows.Forms.DataGridView();
            this.labelDeleteDoctor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocDel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(119, 435);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(558, 435);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 4;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // dataGridViewDocDel
            // 
            this.dataGridViewDocDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocDel.Location = new System.Drawing.Point(167, 45);
            this.dataGridViewDocDel.Name = "dataGridViewDocDel";
            this.dataGridViewDocDel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDocDel.Size = new System.Drawing.Size(419, 351);
            this.dataGridViewDocDel.TabIndex = 3;
            // 
            // labelDeleteDoctor
            // 
            this.labelDeleteDoctor.AutoSize = true;
            this.labelDeleteDoctor.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteDoctor.Location = new System.Drawing.Point(288, 9);
            this.labelDeleteDoctor.Name = "labelDeleteDoctor";
            this.labelDeleteDoctor.Size = new System.Drawing.Size(171, 27);
            this.labelDeleteDoctor.TabIndex = 6;
            this.labelDeleteDoctor.Text = "DeleteDoctor";
            // 
            // DeleteDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 503);
            this.Controls.Add(this.labelDeleteDoctor);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.dataGridViewDocDel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteDoc";
            this.Text = "DeleteDoc";
            this.Load += new System.EventHandler(this.DeleteDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.DataGridView dataGridViewDocDel;
        private System.Windows.Forms.Label labelDeleteDoctor;
    }
}