namespace HospitalManagementProject
{
    partial class PatientWorkArea
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
            this.buttonback = new System.Windows.Forms.Button();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDoc = new System.Windows.Forms.ComboBox();
            this.comboBoxAppStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textSickness = new System.Windows.Forms.TextBox();
            this.textAppId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AppointmentID = new System.Windows.Forms.Label();
            this.textPat = new System.Windows.Forms.TextBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.buttonca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPat
            // 
            this.dataGridViewPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPat.Location = new System.Drawing.Point(3, 56);
            this.dataGridViewPat.Name = "dataGridViewPat";
            this.dataGridViewPat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPat.Size = new System.Drawing.Size(413, 407);
            this.dataGridViewPat.TabIndex = 0;
            this.dataGridViewPat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPat_MouseClick);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(12, 469);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(97, 23);
            this.buttonback.TabIndex = 57;
            this.buttonback.Text = "Logout";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(634, 348);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTime.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "AppTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "Cost";
            // 
            // comboBoxDoc
            // 
            this.comboBoxDoc.FormattingEnabled = true;
            this.comboBoxDoc.Location = new System.Drawing.Point(634, 187);
            this.comboBoxDoc.Name = "comboBoxDoc";
            this.comboBoxDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoc.TabIndex = 71;
            // 
            // comboBoxAppStatus
            // 
            this.comboBoxAppStatus.FormattingEnabled = true;
            this.comboBoxAppStatus.Location = new System.Drawing.Point(634, 269);
            this.comboBoxAppStatus.Name = "comboBoxAppStatus";
            this.comboBoxAppStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAppStatus.TabIndex = 69;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(634, 311);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker.TabIndex = 67;
            this.dateTimePicker.Value = new System.DateTime(2016, 4, 27, 0, 0, 0, 0);
            // 
            // textSickness
            // 
            this.textSickness.Location = new System.Drawing.Point(634, 228);
            this.textSickness.Name = "textSickness";
            this.textSickness.Size = new System.Drawing.Size(121, 20);
            this.textSickness.TabIndex = 66;
            // 
            // textAppId
            // 
            this.textAppId.Location = new System.Drawing.Point(634, 105);
            this.textAppId.Name = "textAppId";
            this.textAppId.ReadOnly = true;
            this.textAppId.Size = new System.Drawing.Size(121, 20);
            this.textAppId.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "AppDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "AppStatus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Sickness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "DoctorName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "PatientName";
            // 
            // AppointmentID
            // 
            this.AppointmentID.AutoSize = true;
            this.AppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentID.Location = new System.Drawing.Point(441, 101);
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.Size = new System.Drawing.Size(141, 25);
            this.AppointmentID.TabIndex = 58;
            this.AppointmentID.Text = "AppointmentID";
            // 
            // textPat
            // 
            this.textPat.Location = new System.Drawing.Point(634, 148);
            this.textPat.Name = "textPat";
            this.textPat.ReadOnly = true;
            this.textPat.Size = new System.Drawing.Size(121, 20);
            this.textPat.TabIndex = 76;
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(634, 386);
            this.textCost.Name = "textCost";
            this.textCost.ReadOnly = true;
            this.textCost.Size = new System.Drawing.Size(121, 20);
            this.textCost.TabIndex = 73;
            // 
            // buttonca
            // 
            this.buttonca.Location = new System.Drawing.Point(530, 469);
            this.buttonca.Name = "buttonca";
            this.buttonca.Size = new System.Drawing.Size(175, 23);
            this.buttonca.TabIndex = 77;
            this.buttonca.Text = "ChangeAppoinmentDetails";
            this.buttonca.UseVisualStyleBackColor = true;
            this.buttonca.Click += new System.EventHandler(this.buttonca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "PatientWorkArea";
            // 
            // PatientWorkArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(846, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonca);
            this.Controls.Add(this.textPat);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDoc);
            this.Controls.Add(this.comboBoxAppStatus);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textSickness);
            this.Controls.Add(this.textAppId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AppointmentID);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.dataGridViewPat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PatientWorkArea";
            this.Text = "PatientWorkArea";
            this.Load += new System.EventHandler(this.PatientWorkArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPat;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDoc;
        private System.Windows.Forms.ComboBox comboBoxAppStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textSickness;
        private System.Windows.Forms.TextBox textAppId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AppointmentID;
        private System.Windows.Forms.TextBox textPat;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Button buttonca;
        private System.Windows.Forms.Label label1;
    }
}