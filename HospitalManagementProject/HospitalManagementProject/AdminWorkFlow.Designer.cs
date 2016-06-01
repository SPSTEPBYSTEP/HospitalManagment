namespace HospitalManagementProject
{
    partial class AdminWorkFlow
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
            this.buttonAddDoctor = new System.Windows.Forms.Button();
            this.buttonAddappointment = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.AdminWorkArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddDoctor
            // 
            this.buttonAddDoctor.Location = new System.Drawing.Point(391, 242);
            this.buttonAddDoctor.Name = "buttonAddDoctor";
            this.buttonAddDoctor.Size = new System.Drawing.Size(134, 23);
            this.buttonAddDoctor.TabIndex = 5;
            this.buttonAddDoctor.Text = "DocInfo";
            this.buttonAddDoctor.UseVisualStyleBackColor = true;
            this.buttonAddDoctor.Click += new System.EventHandler(this.buttonAddDoctor_Click);
            // 
            // buttonAddappointment
            // 
            this.buttonAddappointment.Location = new System.Drawing.Point(391, 293);
            this.buttonAddappointment.Name = "buttonAddappointment";
            this.buttonAddappointment.Size = new System.Drawing.Size(134, 23);
            this.buttonAddappointment.TabIndex = 4;
            this.buttonAddappointment.Text = "AppointmentInfo";
            this.buttonAddappointment.UseVisualStyleBackColor = true;
            this.buttonAddappointment.Click += new System.EventHandler(this.buttonAddappointment_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(391, 188);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(134, 23);
            this.buttonAddPatient.TabIndex = 3;
            this.buttonAddPatient.Text = "PatientInfo";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // AdminWorkArea
            // 
            this.AdminWorkArea.AutoSize = true;
            this.AdminWorkArea.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminWorkArea.Location = new System.Drawing.Point(349, 44);
            this.AdminWorkArea.Name = "AdminWorkArea";
            this.AdminWorkArea.Size = new System.Drawing.Size(211, 27);
            this.AdminWorkArea.TabIndex = 6;
            this.AdminWorkArea.Text = "AdminWorkArea";
            // 
            // AdminWorkFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(915, 504);
            this.Controls.Add(this.AdminWorkArea);
            this.Controls.Add(this.buttonAddDoctor);
            this.Controls.Add(this.buttonAddappointment);
            this.Controls.Add(this.buttonAddPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminWorkFlow";
            this.Text = "AdminWorkFlow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDoctor;
        private System.Windows.Forms.Button buttonAddappointment;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Label AdminWorkArea;
    }
}