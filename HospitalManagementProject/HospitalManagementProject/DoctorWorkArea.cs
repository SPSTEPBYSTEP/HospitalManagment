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
    public partial class DoctorWorkArea : Form
    {
      
        public String name = "";
        DataTable dt = new DataTable();
        public QueryDAL qDal = new QueryDAL();
        public DoctorWorkArea( String name)
        {
            InitializeComponent();

            this.name = name;
            
        }

        private void buttonca_Click(object sender, EventArgs e)
        {
            String appdate = dateTimePicker.Value.ToString();
            String pat = Convert.ToString(comboBoxPat.SelectedItem);
            String apptime = Convert.ToString(comboBoxTime.SelectedItem);
            String appstatus = Convert.ToString(comboBoxAppStatus.SelectedItem);
            String coststatus = Convert.ToString(comboBoxCostStatus.SelectedItem);
            Regex regex = new Regex("^[0-9]+$");
            if (textCost.Text!= "" & textSickness.Text != "" &pat!="" & apptime!="" & appstatus!="" & coststatus!="" & textDoc.Text!="" & regex.IsMatch(textCost.Text))
            {
                

               

                //   string q = "Update hospitalsystem.Patient set LastName='" + textLastName.Text + "', FirstName='" + textFirstName.Text + "',  psswd ='" + textPassword.Text + "', Address='" + textAddress.Text + "', Phone='" + textPhone.Text + "', DOB ='" + dob + "' where username='" + textUserName.Text + "';";

                int row4d = qDal.existingappD(pat, textDoc.Text, appdate, apptime, appstatus);
                int row3d = qDal.existingDocP(textDoc.Text, appdate, apptime, appstatus);
                //int row3p = qdal.existingPat(pat, appdate, apptime, appstatus);

                if (appstatus.Equals("Scheduled")) {

                    if (row4d > 0)
                    {

                        MessageBox.Show("This Patient is already assigned to the another doctor");


                    }

                    else if (row3d > 0)
                    {



                        MessageBox.Show("Doctor is not available");



                    }

                    
                     else {
                            qDal.DocAppUpdate(textSickness.Text, pat, textCost.Text, appstatus, coststatus, appdate, apptime, textAppId.Text);
                            MessageBox.Show("App Updated");
                            dt = qDal.DocWork(name);
                            comboBoxPat.SelectedIndex = -1;
                            comboBoxAppStatus.SelectedIndex = -1;
                            comboBoxTime.SelectedIndex = -1;
                            comboBoxCostStatus.SelectedIndex = -1;
                            textAppId.Clear();
                            textDoc.Clear();
                            textCost.Clear();
                            textSickness.Clear();
                            dateTimePicker.Value = DateTime.Now;

                        


                    }



                }

                else {
                    qDal.DocAppUpdate(textSickness.Text, pat, textCost.Text, appstatus, coststatus, appdate, apptime, textAppId.Text);
                    MessageBox.Show("App Updated");
                    dt = qDal.DocWork(name);
                    comboBoxPat.SelectedIndex = -1;
                    comboBoxAppStatus.SelectedIndex = -1;
                    comboBoxTime.SelectedIndex = -1;
                    comboBoxCostStatus.SelectedIndex = -1;
                    textAppId.Clear();
                    textDoc.Clear();
                    textCost.Clear();
                    textSickness.Clear();
                    dateTimePicker.Value = DateTime.Now;

                }




            }
            else { MessageBox.Show("No fields Should be blank or cost should be a number"); }
        



    }

    private void DoctorWorkArea_Load(object sender, EventArgs e)
        {
            dt = qDal.DocWork(name);

            dataGridViewDoc.DataSource = dt;
            comboBoxPat.DataSource = qDal.retiveList();
            comboBoxAppStatus.DataSource = AppStatusData();
            comboBoxCostStatus.DataSource = CostStatusData();
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

        private void dataGridViewDoc_MouseClick(object sender, MouseEventArgs e)
        {
            textAppId.Text = dataGridViewDoc.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxPat.SelectedItem = dataGridViewDoc.SelectedRows[0].Cells[1].Value.ToString();
            textDoc.Text = dataGridViewDoc.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxTime.SelectedItem = dataGridViewDoc.SelectedRows[0].Cells[3].Value.ToString();
            textSickness.Text = dataGridViewDoc.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxAppStatus.SelectedItem = dataGridViewDoc.SelectedRows[0].Cells[5].Value.ToString();
            textCost.Text = dataGridViewDoc.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxCostStatus.SelectedItem = dataGridViewDoc.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login m = new Login();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }

        private void textCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
