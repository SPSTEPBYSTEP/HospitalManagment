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
    public partial class UpdateAppointment : Form
    {
        DataTable dt = new DataTable();
        public QueryDAL qdal = new QueryDAL();
        public HospitalInformation.Appointment ap;
        public UpdateAppointment(HospitalInformation.Appointment ap)
        {  
       
            InitializeComponent();
            this.ap = ap;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonca_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            String appdate = dateTimePicker.Value.ToString();
            String pat = Convert.ToString(comboBoxPat.SelectedItem);
            String apptime = Convert.ToString(comboBoxTime.SelectedItem);
            String appstatus = Convert.ToString(comboBoxAppStatus.SelectedItem);
            String doc = Convert.ToString(comboBoxDoc.SelectedItem);
            String coststatus = Convert.ToString(comboBoxCostStatus.SelectedItem);

            if (textCost.Text != "" & textSickness.Text != "" & pat != "" & apptime != "" & appstatus != "" & coststatus != "" & doc != "" & regex.IsMatch(textCost.Text))
            {




                //   string q = "Update hospitalsystem.Patient set LastName='" + textLastName.Text + "', FirstName='" + textFirstName.Text + "',  psswd ='" + textPassword.Text + "', Address='" + textAddress.Text + "', Phone='" + textPhone.Text + "', DOB ='" + dob + "' where username='" + textUserName.Text + "';";

                int row4d = qdal.existingappD(pat, doc, appdate, apptime, appstatus);
                int row3d = qdal.existingDocPa(doc, appdate, apptime, appstatus,pat);
                int row3p = qdal.existingPatp(pat, appdate, apptime, appstatus);

                if (appstatus.Equals("Scheduled"))
                {

                    if (row4d > 0)
                    {

                        MessageBox.Show("This Patient is already assigned to the another doctor");


                    }

                    else if (row3d > 0)
                    {



                        MessageBox.Show("Doctor is not available");



                    }
                    //else if (row3p > 0) {

                    //    MessageBox.Show("Patient is not available");
                    //}

                    else {
                        qdal.AppUpdate(textSickness.Text, pat, doc, textCost.Text, appstatus, coststatus, appdate, apptime, textAppId.Text);
                        MessageBox.Show("App Updated");
                        dt = qdal.AppInfo();
                        comboBoxPat.SelectedIndex = -1;
                        comboBoxAppStatus.SelectedIndex = -1;
                        comboBoxTime.SelectedIndex = -1;
                        comboBoxCostStatus.SelectedIndex = -1;
                        textAppId.Clear();
                        comboBoxDoc.SelectedIndex = -1;
                        textCost.Clear();
                        textSickness.Clear();
                        dateTimePicker.Value = DateTime.Now;




                    }



                }

                else {
                    qdal.DocAppUpdate(textSickness.Text, pat, textCost.Text, appstatus, coststatus, appdate, apptime, textAppId.Text);
                    MessageBox.Show("App Updated");
                    dt = qdal.AppInfo();
                    comboBoxPat.SelectedIndex = -1;
                    comboBoxAppStatus.SelectedIndex = -1;
                    comboBoxTime.SelectedIndex = -1;
                    comboBoxCostStatus.SelectedIndex = -1;
                    textAppId.Clear();
                    comboBoxDoc.SelectedIndex = -1;
                    textCost.Clear();
                    textSickness.Clear();
                    dateTimePicker.Value = DateTime.Now;

                }




            }
            else { MessageBox.Show("No fields Should be blank or cost should ne a number"); }



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


        public List<String> CostStatusData()
        {
            List<String> status = new List<String>();
            status.Add("Pending");
            status.Add("Paid");



            return status;
        }

        public List<String> AppStatusData()
        {
            List<String> status = new List<String>();
            status.Add("Scheduled");
            status.Add("Cancelled");



            return status;
        }

        private void UpdateAppointment_Load(object sender, EventArgs e)
        {
            dt = qdal.AppInfo();
            dataGridViewApp.DataSource = dt;
            comboBoxPat.DataSource = qdal.retiveList();
            comboBoxDoc.DataSource = qdal.retieveListdoc();
            comboBoxAppStatus.DataSource = AppStatusData();
            comboBoxCostStatus.DataSource = CostStatusData();
            comboBoxTime.DataSource = AppTime();


        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentInfo m = new AppointmentInfo();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void dataGridViewApp_MouseClick(object sender, MouseEventArgs e)
        {
            textAppId.Text = dataGridViewApp.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxPat.SelectedItem = dataGridViewApp.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxDoc.SelectedItem = dataGridViewApp.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxTime.SelectedItem = dataGridViewApp.SelectedRows[0].Cells[3].Value.ToString();
            textSickness.Text = dataGridViewApp.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxAppStatus.SelectedItem = dataGridViewApp.SelectedRows[0].Cells[5].Value.ToString();
            textCost.Text = dataGridViewApp.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxCostStatus.SelectedItem = dataGridViewApp.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void textCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
