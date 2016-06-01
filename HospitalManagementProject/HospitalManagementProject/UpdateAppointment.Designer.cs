namespace HospitalManagementProject
{
    partial class UpdateAppointment
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
            this.buttonback = new System.Windows.Forms.Button();
            this.comboBoxCostStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewApp = new System.Windows.Forms.DataGridView();
            this.buttonca = new System.Windows.Forms.Button();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPat = new System.Windows.Forms.ComboBox();
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
            this.comboBoxDoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(89, 463);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(97, 23);
            this.buttonback.TabIndex = 121;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // comboBoxCostStatus
            // 
            this.comboBoxCostStatus.FormattingEnabled = true;
            this.comboBoxCostStatus.Location = new System.Drawing.Point(566, 386);
            this.comboBoxCostStatus.Name = "comboBoxCostStatus";
            this.comboBoxCostStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCostStatus.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 119;
            this.label8.Text = "CostStatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 118;
            this.label1.Text = "AdminWorkArea";
            // 
            // dataGridViewApp
            // 
            this.dataGridViewApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApp.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewApp.Name = "dataGridViewApp";
            this.dataGridViewApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApp.Size = new System.Drawing.Size(355, 414);
            this.dataGridViewApp.TabIndex = 117;
            this.dataGridViewApp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewApp_MouseClick);
            // 
            // buttonca
            // 
            this.buttonca.Location = new System.Drawing.Point(478, 461);
            this.buttonca.Name = "buttonca";
            this.buttonca.Size = new System.Drawing.Size(175, 23);
            this.buttonca.TabIndex = 116;
            this.buttonca.Text = "ChangeAppoinmentDetails";
            this.buttonca.UseVisualStyleBackColor = true;
            this.buttonca.Click += new System.EventHandler(this.buttonca_Click);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(566, 311);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTime.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 113;
            this.label7.Text = "AppTime";
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(566, 349);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(121, 20);
            this.textCost.TabIndex = 112;
            this.textCost.TextChanged += new System.EventHandler(this.textCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 111;
            this.label2.Text = "Cost";
            // 
            // comboBoxPat
            // 
            this.comboBoxPat.FormattingEnabled = true;
            this.comboBoxPat.Location = new System.Drawing.Point(566, 109);
            this.comboBoxPat.Name = "comboBoxPat";
            this.comboBoxPat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPat.TabIndex = 110;
            // 
            // comboBoxAppStatus
            // 
            this.comboBoxAppStatus.FormattingEnabled = true;
            this.comboBoxAppStatus.Location = new System.Drawing.Point(566, 232);
            this.comboBoxAppStatus.Name = "comboBoxAppStatus";
            this.comboBoxAppStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAppStatus.TabIndex = 109;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(566, 274);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 4, 29, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker.TabIndex = 108;
            this.dateTimePicker.Value = new System.DateTime(2016, 4, 29, 0, 0, 0, 0);
            // 
            // textSickness
            // 
            this.textSickness.Location = new System.Drawing.Point(566, 191);
            this.textSickness.Name = "textSickness";
            this.textSickness.Size = new System.Drawing.Size(121, 20);
            this.textSickness.TabIndex = 107;
            // 
            // textAppId
            // 
            this.textAppId.Location = new System.Drawing.Point(566, 68);
            this.textAppId.Name = "textAppId";
            this.textAppId.ReadOnly = true;
            this.textAppId.Size = new System.Drawing.Size(121, 20);
            this.textAppId.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(373, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 105;
            this.label9.Text = "AppDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 104;
            this.label6.Text = "AppStatus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 103;
            this.label5.Text = "Sickness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 102;
            this.label4.Text = "DoctorName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "PatientName";
            // 
            // AppointmentID
            // 
            this.AppointmentID.AutoSize = true;
            this.AppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentID.Location = new System.Drawing.Point(373, 64);
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.Size = new System.Drawing.Size(141, 25);
            this.AppointmentID.TabIndex = 100;
            this.AppointmentID.Text = "AppointmentID";
            // 
            // comboBoxDoc
            // 
            this.comboBoxDoc.FormattingEnabled = true;
            this.comboBoxDoc.Location = new System.Drawing.Point(566, 151);
            this.comboBoxDoc.Name = "comboBoxDoc";
            this.comboBoxDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoc.TabIndex = 122;
            this.comboBoxDoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(809, 515);
            this.Controls.Add(this.comboBoxDoc);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.comboBoxCostStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewApp);
            this.Controls.Add(this.buttonca);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPat);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateAppointment";
            this.Text = "UpdateAppointment";
            this.Load += new System.EventHandler(this.UpdateAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.ComboBox comboBoxCostStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewApp;
        private System.Windows.Forms.Button buttonca;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPat;
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
        private System.Windows.Forms.ComboBox comboBoxDoc;
    }
}