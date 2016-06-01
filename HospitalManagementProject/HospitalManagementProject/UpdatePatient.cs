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
    public partial class UpdatePatient : Form
    {
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Windows@123");
        MySqlDataAdapter mcd;

        MySqlCommand command;
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {  
            try {

                // MySqlConnection mcon = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = Windows@123");
                mcd = new MySqlDataAdapter("select * from hospitalsystem.Patient", mcon);
                mcon.Open();
                DataSet ds = new DataSet();
                mcd.Fill(ds, "Patient");
                dataGridPatientUpdate.DataSource = ds.Tables["Patient"];
                mcon.Close();


            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
                }



        public void search()
        {
            try
            {

                // MySqlConnection mcon = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = Windows@123");
                mcd = new MySqlDataAdapter("select * from hospitalsystem.Patient", mcon);
                mcon.Open();
                DataSet ds = new DataSet();
                mcd.Fill(ds, "Patient");
                dataGridPatientUpdate.DataSource = ds.Tables["Patient"];
                mcon.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridPatientUpdate_MouseClick(object sender, MouseEventArgs e)
        {

            textLastName.Text = dataGridPatientUpdate.SelectedRows[0].Cells[0].Value.ToString();
            textFirstName.Text = dataGridPatientUpdate.SelectedRows[0].Cells[1].Value.ToString();
            textUserName.Text = dataGridPatientUpdate.SelectedRows[0].Cells[2].Value.ToString();
            textPassword.Text = dataGridPatientUpdate.SelectedRows[0].Cells[3].Value.ToString();
            textAddress.Text = dataGridPatientUpdate.SelectedRows[0].Cells[5].Value.ToString();
            textPhone.Text = dataGridPatientUpdate.SelectedRows[0].Cells[6].Value.ToString();
           // textd.Text = dataGridPatientUpdate.SelectedRows[0].Cells[0].Value.ToString();


        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        public void Opencon()
        {

            if (mcon.State == ConnectionState.Closed)
            {

                mcon.Open();

            }
        }

        public void closeCon()
        {

            if (mcon.State == ConnectionState.Open)
            {

                mcon.Close();


            }
        }

        public void createPatient(string q)
        {

            try
            {
                Opencon();
                command = new MySqlCommand(q, mcon);

                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Query Executed");

                }
                else { MessageBox.Show("Query Not Executed"); }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {

                closeCon();

            }

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]{10}$");
            if (textLastName.Text != "" & textFirstName.Text != "" & textAddress.Text != "" & textPhone.Text != "" & textUserName.Text != "" & textPassword.Text != "" & regex.IsMatch(textPhone.Text))
            {
                 

                String dob = dateTimePicker.Value.ToString();
                string q = "Update hospitalsystem.Patient set LastName='" + textLastName.Text + "', FirstName='" + textFirstName.Text + "',  psswd ='" + textPassword.Text + "', Address='" + textAddress.Text + "', Phone='" + textPhone.Text + "', DOB ='" + dob + "' where username='" + textUserName.Text + "';";



                createPatient(q);
                search();
                textPassword.Clear();
                textAddress.Clear();
                textLastName.Clear();
                textPhone.Clear();
                textFirstName.Clear();
                textUserName.Clear();
                dateTimePicker.Value = DateTime.Now;




            }
            else { MessageBox.Show("No fields Should be blank or invalid Phone number"); }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientInfo p = new PatientInfo();
            p.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
