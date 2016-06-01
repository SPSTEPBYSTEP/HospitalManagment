using HospitalManagementProject.DAL;
using MySql.Data.MySqlClient;
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
    public partial class DoctorInfo : Form
    {
        public ConnectionDal cdal = new ConnectionDal();
        public QueryDAL qdal = new QueryDAL();
        public HospitalInformation.Doctor doc;
        public DoctorInfo()
        {
            InitializeComponent();
            
        }

        public List<String> ComboData()
        {
            List<String> role = new List<String>();
            role.Add("Doctor");



            return role;
        }


        public List<String> Specialist()
        {
            List<String> spe = new List<String>();
            spe.Add("Heart");
            spe.Add("Neurologist");
            spe.Add("Brain");
            spe.Add("ortho");
            spe.Add("pediatrician");


            return spe;
        }




       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteDoc s = new DeleteDoc(doc);
            s.Show();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorUpdate s = new DoctorUpdate();
            s.Show();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textLastName.Text != "" & textFirstName.Text != "" & textUserName.Text != "" & textPassword.Text != "") { 
                String role = Convert.ToString(comboBoxRole.SelectedItem);
                String spec = Convert.ToString(comboBoxSpecialist.SelectedItem);




                doc = new HospitalInformation.Doctor(spec, textFirstName.Text, textLastName.Text, textUserName.Text, textPassword.Text, role);
                int rows = qdal.insertDoctor(doc);
                if (rows > 0)
                {
                    MessageBox.Show("Query Executed");

                }


            }

            else { MessageBox.Show("Fields cannot be empty"); }
        }


       
    private void DoctorInfo_Load(object sender, EventArgs e)
        {
            comboBoxRole.DataSource = ComboData();
            comboBoxSpecialist.DataSource = Specialist();
        }
    }
}
