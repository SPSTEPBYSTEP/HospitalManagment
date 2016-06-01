using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementProject.DAL
{
  public class QueryDAL
    {
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Windows@123");
        public ConnectionDal db = new ConnectionDal();
        public HospitalInformation.Patient pa;
        public HospitalInformation.Doctor doc;
     



        public int insertPatient(HospitalInformation.Patient pm)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into hospitalsystem.Patient(LastName,FirstName,userName,psswd,Role,Address,Phone,DOB) values ('" + pm.LastName + "','" + pm.FirstName + "','" + pm.UserName + "','" + pm.Password + "','" + pm.Role + "','" + pm.Address + "','" + pm.Address + "','" + pm.DOB + "')";


            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('New Patient is added')";
            db.ExeNonQuery(command2);

            return db.ExeNonQuery(command);
        }





        public int CreateApp(HospitalInformation.Appointment ap)
        {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "insert into hospitalsystem.Appointment(Appointmentid,PatientName,Doctorname,appTime,Sickness,AppStatus,Cost,CostStatus,Appdate) values ('" + ap.ID + "','" + ap.PatientName + "','" + ap.DoctorName + "','" + ap.Time + "','" + ap.Sickness + "','" + ap.appStatus + "','" + ap.Cost + "','" + ap.costStatus + "','" + ap.appdate + "')";
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('New Appointment is added')";
            db.ExeNonQuery(command2);
            return db.ExeNonQuery(command);
        }


        public int insertDoctor(HospitalInformation.Doctor doc)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into hospitalsystem.Doctor(LastName, FirstName, userName, psswd, Role, Specialist) values('" + doc.LastName + "', '" + doc.FirstName + "', '" + doc.UserName + "', '" + doc.Password + "', '" + doc.Role + "', '" + doc.Type + "')";

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('New Doctor is added')";
            db.ExeNonQuery(command2);



            return db.ExeNonQuery(command);
        }


        public int existingapp(String pname, String dname, String date, String time, String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE PatientName ='" + pname + "'and Doctorname='" + dname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='" + Status + "'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking if the appointment exists')";
            db.ExeNonQuery(command2);


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }


        public int existingappD(String pname, String dname, String date, String time, String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE PatientName ='" + pname + "'and Doctorname !='" + dname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='" + Status + "'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for duplicate doctor assignment')";
            db.ExeNonQuery(command2);

            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }


        public int existingappDo(String doc, String pname, String date, String time, String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE Doctorname ='" + doc + "'and PatientName !='" + pname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='" + Status + "'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for duplicate doctor assignment')";
            db.ExeNonQuery(command2);


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }

        public int existingDocP(String dname, String date, String time, String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE Doctorname='" + dname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='Scheduled'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for duplicate doctor assignment')";
            db.ExeNonQuery(command2);

            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }
        public int existingDocPa(String dname, String date, String time, String Status, String pname)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE Doctorname='" + dname + "'and PatientName!='" + pname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='Scheduled'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for duplicate doctor assignment')";
            db.ExeNonQuery(command2);


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }


        public int existingPatp(String pname, String date, String time, String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE PatientName='" + pname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='Scheduled'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for duplicate Patient assignment')";
            db.ExeNonQuery(command2);


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }










        public int existingDocPa(String pname, String date, String time, String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE PatientName='" + pname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='Scheduled'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

         
            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for duplicate Patient assignment')";
            db.ExeNonQuery(command2);


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }

        public int existingDoc(String dname, String date, String time, String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE Doctorname='" + dname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='" + Status + "'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

           
            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for exsisting doc')";
            db.ExeNonQuery(command2);


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }



        public int existingPat(String pname, String date, String time , String Status)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.appointment WHERE PatientName='" + pname + "'and Appdate='" + date + "'and appTime='" + time + "'and AppStatus='" + Status + "'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

          
            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Checking for exsisting Patient ')";
            db.ExeNonQuery(command2);


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }


        public DataTable DocWork(String name)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = command.CommandText = "Select * from hospitalsystem.appointment WHERE Doctorname='" + name + "'";
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('fetching doc details')";


            return db.ExecuteReader(command);

        }

        public DataTable PatientInfo()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = command.CommandText = "Select * from hospitalsystem.Patient ";


            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('fetching Patient details')";
            return db.ExecuteReader(command);
        }


        public DataTable AppInfo()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = command.CommandText = "Select * from hospitalsystem.Appointment ";

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('fetching Appointment details')";




            return db.ExecuteReader(command);
        }

        public int deletePatient( String pa) {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from hospitalsystem.Patient where Username='"+ pa+ "'";

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Patient was deleted')";

            return db.ExeNonQuery(command);


        }

        public int deleteDoctor(String pa)
        {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from hospitalsystem.Doctor where Username='" + pa + "'";

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Doctor was deleted')";

            return db.ExeNonQuery(command);


        }

        public int deleteApp(String pa)
        {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from hospitalsystem.Appointment where Appointmentid='" + pa + "'";

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Appointment was deleted')";





            return db.ExeNonQuery(command);


        }
        public DataTable DoctorInfo()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = command.CommandText = "Select * from hospitalsystem.Doctor ";

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('fetching doc details')";



            return db.ExecuteReader(command);
        }


      


        public int existingpUser(String username, String password)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.Patient WHERE Username='" + username + "'and psswd='" + password + "'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Patient login check')";


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }

        public int existingdUser(String username, String password)
        {
            int has = 0;
            string query = "Select * from hospitalsystem.Doctor WHERE Username='" + username + "'and psswd='" + password + "'";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Doctor login check')";


            if (msd.HasRows)
            {
                has = 1;


            }

            else { has = -1; }
            mcon.Close();
            return has;
        }






        public void DocAppUpdate(String sickness, String pname, String cost, String appstatus, String coststatus, String date, String apptime, String appid)
        {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "Update hospitalsystem.Appointment set PatientName='" + pname + "',appTime='" + apptime + "',Sickness='" + sickness + "',AppStatus='" + appstatus + "',Cost='" + cost + "',CostStatus='" + coststatus + "',Appdate='" + date + "' where Appointmentid='" + appid + "';";

            MySqlCommand command2 = new MySqlCommand();



            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('doctor Updated Appointment')";
            db.ExeNonQuery(command2);





            db.ExeNonQuery(command);
        }


        public void DocUpdate(String LastName, String FirstName, String  userName, String psswd, String Role, String Specialist)
        {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "Update hospitalsystem.Doctor set LastName='" + LastName + "',FirstName='" + FirstName + "',psswd='" + psswd + "',Role='" + Role + "',Specialist='" + Specialist + "'where userName='" + userName + "';";

            MySqlCommand command2 = new MySqlCommand();



            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('doctor Details were updated')";
            db.ExeNonQuery(command2);





            db.ExeNonQuery(command);
        }

        public void AppUpdate(String sickness, String pname, String dname,String cost, String appstatus, String coststatus, String date, String apptime, String appid)
        {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "Update hospitalsystem.Appointment set PatientName='" + pname + "',Doctorname='" + pname + "',appTime='" + apptime + "',Sickness='" + sickness + "',AppStatus='" + appstatus + "',Cost='" + cost + "',CostStatus='" + coststatus + "',Appdate='" + date + "' where Appointmentid='" + appid + "';";

            MySqlCommand command2 = new MySqlCommand();



            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('doctor Updated Appointment')";
            db.ExeNonQuery(command2);





            db.ExeNonQuery(command);
        }

        public void PatAppUpdate(String sickness, String dname, String cost, String appstatus, String date, String apptime, String appid)
        {
            MySqlCommand command = new MySqlCommand();



            command.CommandType = CommandType.Text;
            command.CommandText = "Update hospitalsystem.Appointment set Doctorname='" + dname + "',appTime='" + apptime + "',Sickness='" + sickness + "',AppStatus='" + appstatus + "',Cost='" + cost + "',Appdate='" + date + "' where Appointmentid='" + appid + "';";

            MySqlCommand command2 = new MySqlCommand();



            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('doctor Updated Appointment')";
            db.ExeNonQuery(command2);





            db.ExeNonQuery(command);
        }

        public List<String> retiveList()
        {
            List<String> name = new List<String>();
            string query = "select * from hospitalsystem.patient";
            MySqlCommand command = new MySqlCommand(query,mcon);
            MySqlDataReader msd;
            mcon.Open();

             msd= command.ExecuteReader();
            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('Retriving list of Patients')";


            while (msd.Read()) {
                 name.Add(msd.GetString("username"));
               

            }
            mcon.Close();
            return name;
        }


        public DataTable PatWork(String name)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = command.CommandText = "Select * from hospitalsystem.Appointment where PatientName= '" + name + "'";

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('getting doc info on gridtable')";




            return db.ExecuteReader(command);
        }

        public List<String> retieveListdoc()
        {
            List<String> name = new List<String>();
            string query = "select * from hospitalsystem.doctor";
            MySqlCommand command = new MySqlCommand(query, mcon);
            MySqlDataReader msd;
            mcon.Open();

            msd = command.ExecuteReader();

            MySqlCommand command2 = new MySqlCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "insert into hospitalsystem.Log(log_event) values('fetching list of Doctors')";


            while (msd.Read())
            {
                name.Add(msd.GetString("Username"));


            }
            mcon.Close();
            return name;
        }


    }





}
