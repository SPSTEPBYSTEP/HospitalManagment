using HospitalManagementProject.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalManagementProject
{
    public partial class PatientInfo : Form
    {
        //private List<HospitalInformation.Patient> studentin = new List<HospitalInformation.Patient>();

        public ConnectionDal cdal = new ConnectionDal();
        public QueryDAL qdal = new QueryDAL();
        public HospitalInformation.Patient pm;


        public PatientInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public List<String> ComboData()
        {
            List<String> role = new List<String>();
            role.Add("Patient");
           
            

            return role;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]{10}$");
            if (textLastName.Text != "" & textFirstName.Text != "" & textAddress.Text != "" & textPhone.Text != "" & textUserName.Text != "" & textPassword.Text != "" &regex.IsMatch(textPhone.Text))
            {

                String role = Convert.ToString(comboBoxRole.SelectedItem);
                String dob = dateTimePicker.Value.ToString();

                pm = new HospitalInformation.Patient(textAddress.Text, textPhone.Text, dob, textFirstName.Text, textLastName.Text, textUserName.Text, textPassword.Text, role);
                int rows = qdal.insertPatient(pm);
                if (rows > 0)
                {
                    MessageBox.Show("Query Executed");

                }


            }

            else { MessageBox.Show("Fields Cannot be empty or phone number should be only 10 digit numbers"); }


        }





        

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            comboBoxRole.DataSource= ComboData();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePatient s = new UpdatePatient();
            s.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePatient m = new DeletePatient(pm);
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWorkFlow s = new AdminWorkFlow();
            s.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
         Login s = new Login();
            s.Show();
        }
    }
}
