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
    public partial class DeletePatient : Form
    {
        public HospitalInformation.Patient pa;
        public ConnectionDal cdal = new ConnectionDal();
        public QueryDAL qdal = new QueryDAL();
        DataTable dt = new DataTable();
        public DeletePatient(HospitalInformation.Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
        }

        private void DeletePatient_Load(object sender, EventArgs e)
        {
            dt = qdal.PatientInfo();
            dataGridViewPat.DataSource = dt;


        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
           String name = dataGridViewPat.SelectedRows[0].Cells[2].Value.ToString();
           

            DialogResult dialogResult = MessageBox.Show("Are You Sure you want to delete", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                qdal.deletePatient(name);
                dt = qdal.PatientInfo();
                dataGridViewPat.DataSource = dt;
                
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientInfo m = new PatientInfo();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
    }

