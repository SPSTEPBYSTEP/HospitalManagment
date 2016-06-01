using System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTesting
{
   public class Conn
    {
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Windows@123");

        public MySqlConnection Opencon()
        {

            if (mcon.State == ConnectionState.Closed)
            {

                mcon.Open();


            }


            return mcon;
        }




        public MySqlConnection closeCon()
        {

            if (mcon.State == ConnectionState.Open)
            {

                mcon.Close();


            }

            return mcon;
        }


        public int ExeNonQuery(MySqlCommand command)  // Create this function to perform update/insert/delete etc.
        {
            int rowsAffected = -1;
            try
            {
                command.Connection = Opencon();

                rowsAffected = command.ExecuteNonQuery();



            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            finally
            {

                closeCon();

            }

            return rowsAffected;
        }



        public DataTable ExecuteReader(MySqlCommand command) // this method will perform operation select query
        {
            command.Connection = Opencon();

            MySqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = command.ExecuteReader();
            dt.Load(sdr);
            closeCon();
            return dt;
        }



    }


}

