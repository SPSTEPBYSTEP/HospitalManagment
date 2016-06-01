using HospitalManagementProject.DAL;
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
    public partial class DoctorUpdate : Form
    {
        public ConnectionDal cdal = new ConnectionDal();
        public QueryDAL qdal = new QueryDAL();
        public HospitalInformation.Doctor doc;
        DataTable dt = new DataTable();
        public DoctorUpdate()
        {
            InitializeComponent();
        }

        private void dataGridViewDoc_MouseClick(object sender, MouseEventArgs e)
        {
            textLastName.Text = dataGridViewDoc.SelectedRows[0].Cells[0].Value.ToString();
            textFirstName.Text = dataGridViewDoc.SelectedRows[0].Cells[1].Value.ToString();
            textUserName.Text = dataGridViewDoc.SelectedRows[0].Cells[2].Value.ToString();
            textPassword.Text = dataGridViewDoc.SelectedRows[0].Cells[3].Value.ToString();
           comboBoxRole.SelectedItem = dataGridViewDoc.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxSpecialist.SelectedItem= dataGridViewDoc.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void DoctorUpdate_Load(object sender, EventArgs e)
        { dt = qdal.DoctorInfo();
            comboBoxRole.DataSource = ComboData();
            comboBoxSpecialist.DataSource = Specialist();
            dataGridViewDoc.DataSource = dt;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorInfo s = new DoctorInfo();
            s.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            String role = Convert.ToString(comboBoxRole.SelectedItem);
            String spec = Convert.ToString(comboBoxSpecialist.SelectedItem);

            if (textLastName.Text != "" & textFirstName.Text != "" & role != "" & spec != "" & textUserName.Text != "" & textPassword.Text != "")
            {
                


                qdal.DocUpdate(textLastName.Text, textFirstName.Text, textUserName.Text, textPassword.Text,role,spec);

                MessageBox.Show("Doctor details are updated");

                dt =qdal.DoctorInfo();
               
                textPassword.Clear();
                
                textLastName.Clear();
               
                textFirstName.Clear();
                textUserName.Clear();
                comboBoxRole.SelectedIndex = -1;
                comboBoxSpecialist.SelectedIndex = -1;




            }
            else { MessageBox.Show("No fields Should be blank"); }
        }

    }
}

