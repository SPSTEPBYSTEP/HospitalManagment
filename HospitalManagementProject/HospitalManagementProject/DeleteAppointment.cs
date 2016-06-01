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
    public partial class DeleteAppointment : Form
    {  public HospitalInformation.Appointment ap;
        public ConnectionDal cdal = new ConnectionDal();
        public QueryDAL qdal = new QueryDAL();
        DataTable dt = new DataTable();
        public DeleteAppointment(HospitalInformation.Appointment ap)
        {
            InitializeComponent();
            this.ap = ap;
        }
        
        private void DeleteAppointment_Load(object sender, EventArgs e)
        {
            dt = qdal.AppInfo();
            dataGridViewAppDelete.DataSource = dt;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentInfo m = new AppointmentInfo();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String p= dataGridViewAppDelete.SelectedRows[0].Cells[0].Value.ToString();


            DialogResult dialogResult = MessageBox.Show("Are You Sure you want to delete", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                qdal.deleteApp(p);
                dt = qdal.AppInfo();
                dataGridViewAppDelete.DataSource = dt;

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dataGridViewAppDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

