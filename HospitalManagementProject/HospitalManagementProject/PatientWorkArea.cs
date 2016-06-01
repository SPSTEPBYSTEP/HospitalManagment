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
    public partial class PatientWorkArea : Form
    {
        public String name = "";
        DataTable dt = new DataTable();
        public QueryDAL qdal = new QueryDAL();
        public HospitalInformation.Appointment ap;
        public PatientWorkArea(String name)
        {
            InitializeComponent();
            this.name = name;

        }

        private void buttonca_Click(object sender, EventArgs e)
        {
            String appdate = dateTimePicker.Value.ToString();
            String doc = Convert.ToString(comboBoxDoc.SelectedItem);
            String apptime = Convert.ToString(comboBoxTime.SelectedItem);
            String appstatus = Convert.ToString(comboBoxAppStatus.SelectedItem);


            if (textCost.Text != "" & textSickness.Text != "" & doc != "" & apptime != "" & appstatus != "" & textPat.Text != "")
            {




                //   string q = "Update hospitalsystem.Patient set LastName='" + textLastName.Text + "', FirstName='" + textFirstName.Text + "',  psswd ='" + textPassword.Text + "', Address='" + textAddress.Text + "', Phone='" + textPhone.Text + "', DOB ='" + dob + "' where username='" + textUserName.Text + "';";

                int row4d = qdal.existingappDo(textPat.Text, doc, appdate, apptime, appstatus);
                int row3d = qdal.existingDocPa(doc, appdate, apptime, appstatus);
                //int row3p = qdal.existingPat(pat, appdate, apptime, appstatus);

                if (appstatus.Equals("Scheduled"))
                {

                    if (row4d > 0)
                    {

                        MessageBox.Show("This Doc is already assigned to the another Patient");


                    }

                    else if (row3d > 0)
                    {



                        MessageBox.Show("Patient is not available");



                    }


                    else {
                        // qdal.PatAppUpdate(textSickness.Text, doc, textCost.Text, appstatus, appdate, apptime, textAppId.Text);
                        MessageBox.Show("App Updated");
                        dt = qdal.PatWork(name);
                        comboBoxDoc.SelectedIndex = -1;
                        comboBoxAppStatus.SelectedIndex = -1;
                        comboBoxTime.SelectedIndex = -1;

                        textAppId.Clear();
                        textPat.Clear();
                        textCost.Clear();
                        dateTimePicker.Value = DateTime.Now;




                    }



                }

                else {
                    qdal.PatAppUpdate(textSickness.Text, doc, textCost.Text, appstatus, appdate, apptime, textAppId.Text);
                    MessageBox.Show("App Updated");
                    dt = qdal.DocWork(name);
                    comboBoxDoc.SelectedIndex = -1;
                    comboBoxAppStatus.SelectedIndex = -1;
                    comboBoxTime.SelectedIndex = -1;

                    textAppId.Clear();
                    textPat.Clear();
                    textCost.Clear();
                    textSickness.Clear();
                    dateTimePicker.Value = DateTime.Now;

                }




            }
            else { MessageBox.Show("No fields Should be blank"); }



        }

        private void PatientWorkArea_Load(object sender, EventArgs e)
        {

            dt = qdal.PatWork(name);
            dataGridViewPat.DataSource = dt;
            
            comboBoxDoc.DataSource = qdal.retieveListdoc();
            comboBoxAppStatus.DataSource = AppStatusData();
            
            comboBoxTime.DataSource = AppTime();
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
        private void dataGridViewPat_MouseClick(object sender, MouseEventArgs e)
        {
           
          
            //    ap=(HospitalInformation.Appointment)dataGridViewPat.SelectedRows[0].DataBoundItem;
            //if (ap != null)

            //{
                //textAppId.Text = Convert.ToString(ap.ID);
                textAppId.Text = dataGridViewPat.SelectedRows[0].Cells[0].Value.ToString();
                textPat.Text = dataGridViewPat.SelectedRows[0].Cells[1].Value.ToString();
                comboBoxDoc.SelectedItem = dataGridViewPat.SelectedRows[0].Cells[2].Value.ToString();
                comboBoxTime.SelectedItem = dataGridViewPat.SelectedRows[0].Cells[3].Value.ToString();
                textSickness.Text = dataGridViewPat.SelectedRows[0].Cells[4].Value.ToString();
                comboBoxAppStatus.SelectedItem = dataGridViewPat.SelectedRows[0].Cells[5].Value.ToString();
                textCost.Text = dataGridViewPat.SelectedRows[0].Cells[6].Value.ToString();
            //}
            
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login m = new Login();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
}
