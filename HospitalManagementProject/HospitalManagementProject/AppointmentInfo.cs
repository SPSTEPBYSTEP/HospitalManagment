using HospitalManagementProject.DAL;
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
    public partial class AppointmentInfo : Form
    {
        public ConnectionDal cdal = new ConnectionDal();
        public QueryDAL qdal = new QueryDAL();
        public HospitalInformation.Appointment ap;
        public AppointmentInfo()
        {
            InitializeComponent();
        }
       

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            String date = dateTimePicker.Value.ToString();
            String coststatus = Convert.ToString(comboBoxCostStatus.SelectedItem);
            String pat= Convert.ToString(comboBoxPatient.SelectedItem);
            String time = Convert.ToString(comboBoxTime.SelectedItem);
            String appstatus = Convert.ToString(comboBoxTime.SelectedItem);
            String doc = Convert.ToString(comboBoxDoc.SelectedItem);
            String rcost = textCost.Text;
            Regex regex = new Regex("^[0-9]+$");


            if (textCost.Text != "" & textSickness.Text != "" & pat != "" & time != "" & appstatus != "" & coststatus != "" & doc != "" & regex.IsMatch(rcost))
            {

                ap = new HospitalInformation.Appointment(time, Convert.ToString(comboBoxPatient.SelectedItem), Convert.ToString(comboBoxDoc.SelectedItem), textSickness.Text, Convert.ToString(comboBoxAppStatus.SelectedItem), textCost.Text, coststatus, date);

                int row4d = qdal.existingapp(ap.PatientName, ap.DoctorName, ap.appdate, ap.Time, ap.appStatus);
                int row3d = qdal.existingDoc(ap.DoctorName, ap.appdate, ap.Time, ap.appStatus);
                int row3p = qdal.existingPat(ap.PatientName, ap.appdate, ap.Time, ap.appStatus);


                if (row4d > 0)
                {

                    MessageBox.Show("This Patient is already assigned to the given doctor");


                }
                else if (row3d > 0)
                {

                    MessageBox.Show("Doctor is not available");


                }
                else if (row3p > 0)
                {

                    MessageBox.Show("Patient is not available for the given time");


                }

                else
                {
                    double cost = HospitalInformation.Appointment.costcal(textCost.Text);
                    ap.Cost = Convert.ToString(cost);
                    int rows = qdal.CreateApp(ap);
                    if (rows > 0)
                    {
                        MessageBox.Show("Query Executed");

                    }
                }
            }
            else { MessageBox.Show("Fields shouldnot be empty or cpst should be number"); }





        }
        public List<String> AppTime()
        {
            List<String> status = new List<String>();
            status.Add("01:00 pm");
            status.Add("02:00 pm");
            status.Add("03:00 pm");
            status.Add("04:00 pm");
            status.Add("05:00 pm");
            status.Add("06:00 pm");
            status.Add("07:00 pm");
            status.Add("08:00 pm");
            status.Add("09:00 pm");
            status.Add("10:00 am");
            status.Add("11:00 am");
            status.Add("12:00 noon");





            return status;
        }

        public List<String> AppStatusData()
        {
            List<String> status = new List<String>();
            status.Add("Scheduled");
           
            

            return status;
        }


        public List<String> CostStatusData()
        {
            List<String> status = new List<String>();
            status.Add("Pending");



            return status;
        }

        private void AppointmentInfo_Load(object sender, EventArgs e)
        {
            comboBoxAppStatus.DataSource = AppStatusData();
            comboBoxCostStatus.DataSource = CostStatusData();
            comboBoxTime.DataSource = AppTime();
            comboBoxPatient.DataSource = qdal.retiveList();
            comboBoxDoc.DataSource = qdal.retieveListdoc();

        }

        private void comboBoxAppStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAppointment m = new DeleteAppointment(ap);
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateAppointment m = new UpdateAppointment(ap);
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login m = new Login();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWorkFlow m = new AdminWorkFlow();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
}
