namespace HospitalManagementProject
{
    partial class AppointmentInfo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textSickness = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AppointmentID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxCostStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxAppStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.comboBoxDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppointmentInfo";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(374, 325);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker.TabIndex = 37;
            this.dateTimePicker.Value = new System.DateTime(2016, 4, 27, 0, 0, 0, 0);
            // 
            // textSickness
            // 
            this.textSickness.Location = new System.Drawing.Point(374, 200);
            this.textSickness.Name = "textSickness";
            this.textSickness.Size = new System.Drawing.Size(121, 20);
            this.textSickness.TabIndex = 32;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(374, 77);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.ReadOnly = true;
            this.textFirstName.Size = new System.Drawing.Size(121, 20);
            this.textFirstName.TabIndex = 30;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "AppDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "CostStatus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "AppStatus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sickness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "DoctorName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "PatientName";
            // 
            // AppointmentID
            // 
            this.AppointmentID.AutoSize = true;
            this.AppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentID.Location = new System.Drawing.Point(181, 73);
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.Size = new System.Drawing.Size(141, 25);
            this.AppointmentID.TabIndex = 22;
            this.AppointmentID.Text = "AppointmentID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(578, 454);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Cancel";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(321, 454);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 40;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(66, 454);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 39;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxCostStatus
            // 
            this.comboBoxCostStatus.FormattingEnabled = true;
            this.comboBoxCostStatus.Location = new System.Drawing.Point(374, 285);
            this.comboBoxCostStatus.Name = "comboBoxCostStatus";
            this.comboBoxCostStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCostStatus.TabIndex = 42;
            // 
            // comboBoxAppStatus
            // 
            this.comboBoxAppStatus.FormattingEnabled = true;
            this.comboBoxAppStatus.Location = new System.Drawing.Point(374, 241);
            this.comboBoxAppStatus.Name = "comboBoxAppStatus";
            this.comboBoxAppStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAppStatus.TabIndex = 43;
            this.comboBoxAppStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppStatus_SelectedIndexChanged);
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(374, 118);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPatient.TabIndex = 44;
            // 
            // comboBoxDoc
            // 
            this.comboBoxDoc.FormattingEnabled = true;
            this.comboBoxDoc.Location = new System.Drawing.Point(374, 159);
            this.comboBoxDoc.Name = "comboBoxDoc";
            this.comboBoxDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoc.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Cost";
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(374, 396);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(121, 20);
            this.textCost.TabIndex = 47;
            this.textCost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "AppTime";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(374, 362);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTime.TabIndex = 49;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(578, 32);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 50;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonBack1
            // 
            this.buttonBack1.Location = new System.Drawing.Point(34, 34);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(75, 23);
            this.buttonBack1.TabIndex = 51;
            this.buttonBack1.Text = "Back";
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // AppointmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(725, 514);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDoc);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.comboBoxAppStatus);
            this.Controls.Add(this.comboBoxCostStatus);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textSickness);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AppointmentID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppointmentInfo";
            this.Text = "AppointmentInfo";
            this.Load += new System.EventHandler(this.AppointmentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textSickness;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AppointmentID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxCostStatus;
        private System.Windows.Forms.ComboBox comboBoxAppStatus;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.ComboBox comboBoxDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack1;
    }
}