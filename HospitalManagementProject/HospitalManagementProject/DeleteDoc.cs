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
    public partial class DeleteDoc : Form
    {
        public HospitalInformation.Doctor pa;
        public ConnectionDal cdal = new ConnectionDal();
        public QueryDAL qdal = new QueryDAL();
        DataTable dt = new DataTable();
        public DeleteDoc(HospitalInformation.Doctor pa)
        {
            this.pa = pa;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorInfo m = new DoctorInfo();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void DeleteDoc_Load(object sender, EventArgs e)
        {
            dt = qdal.DoctorInfo();
            dataGridViewDocDel.DataSource = dt;

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            String name = dataGridViewDocDel.SelectedRows[0].Cells[2].Value.ToString();


            DialogResult dialogResult = MessageBox.Show("Are You Sure you want to delete", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                qdal.deleteDoctor(name);
                dt = qdal.PatientInfo();
                dataGridViewDocDel.DataSource = dt;

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
    }

