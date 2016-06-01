namespace HospitalManagementProject
{
    partial class UpdatePatient
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
            this.dataGridPatientUpdate = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.labelUpdatePatient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatientUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPatientUpdate
            // 
            this.dataGridPatientUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatientUpdate.Location = new System.Drawing.Point(22, 51);
            this.dataGridPatientUpdate.Name = "dataGridPatientUpdate";
            this.dataGridPatientUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPatientUpdate.Size = new System.Drawing.Size(408, 394);
            this.dataGridPatientUpdate.TabIndex = 0;
            this.dataGridPatientUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridPatientUpdate_MouseClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(642, 326);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker.TabIndex = 37;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(642, 170);
            this.textUserName.Name = "textUserName";
            this.textUserName.ReadOnly = true;
            this.textUserName.Size = new System.Drawing.Size(94, 20);
            this.textUserName.TabIndex = 35;
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(642, 210);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(94, 20);
            this.textAddress.TabIndex = 33;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(642, 282);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(94, 20);
            this.textPhone.TabIndex = 32;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(642, 245);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(94, 20);
            this.textPassword.TabIndex = 31;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(642, 135);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(94, 20);
            this.textFirstName.TabIndex = 30;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(449, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "DOB";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "UserName";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(642, 99);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(94, 20);
            this.textLastName.TabIndex = 39;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(567, 390);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(97, 23);
            this.buttonUpdate.TabIndex = 40;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(567, 46);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(97, 23);
            this.buttonback.TabIndex = 41;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // labelUpdatePatient
            // 
            this.labelUpdatePatient.AutoSize = true;
            this.labelUpdatePatient.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdatePatient.Location = new System.Drawing.Point(333, 9);
            this.labelUpdatePatient.Name = "labelUpdatePatient";
            this.labelUpdatePatient.Size = new System.Drawing.Size(179, 27);
            this.labelUpdatePatient.TabIndex = 42;
            this.labelUpdatePatient.Text = "UpdatePatient";
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(806, 466);
            this.Controls.Add(this.labelUpdatePatient);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPatientUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdatePatient";
            this.Text = "UpdatePatient";
            this.Load += new System.EventHandler(this.UpdatePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatientUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPatientUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Label labelUpdatePatient;
    }
}