using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementProject
{
    public partial class AdminWorkFlow : Form
    {
        //private List<HospitalInformation.Patient> patient = new List<HospitalInformation.Patient>();
        public AdminWorkFlow()
        {
            InitializeComponent();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientInfo s = new PatientInfo();
            s.Show();
           
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorInfo s = new DoctorInfo();
            s.Show();
        }

        private void buttonAddappointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentInfo s = new AppointmentInfo();
            s.Show();
        }
    }
}
