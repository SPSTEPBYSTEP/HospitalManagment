using HospitalManagementProject.DAL;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementProject
{
    public partial class Login : Form
    {
        static protected ILog log = LogManager.GetLogger("Task");
        public QueryDAL qdal = new QueryDAL();
        public Login()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;
            InitializeComponent();

            log.Info("hello world");
        }

        private int att = 0;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            log.Info("hello world");
            String name = textUsername.Text;
            String password = textPassword.Text;

            int up = qdal.existingpUser(name,password);
            int ud = qdal.existingdUser(name, password);

            if (up > 0) {

                MessageBox.Show("Welcome Patient");
                this.Hide();
                PatientWorkArea m = new PatientWorkArea(name);
                m.Closed += (s, args) => this.Close();
                m.Show();


            }
    

           

            else if (ud > 0)
            {

                MessageBox.Show("Welcome Doctor");
                this.Hide();
                DoctorWorkArea m = new DoctorWorkArea(name);
                m.Closed += (s, args) => this.Close();
                m.Show();


            }
            else if (textUsername.Text == "Pranali" && textPassword.Text == "Password")

            
                {
                    MessageBox.Show("Welcome Admin");
                    this.Hide();
                    AdminWorkFlow m = new AdminWorkFlow();
                    m.Closed += (s, args) => this.Close();
                    m.Show();
                
               
            }

            else {

                MessageBox.Show("Incorrect Credentials");
            }
        }
    }
}
