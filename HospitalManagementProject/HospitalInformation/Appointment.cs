using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformation
{
   public class Appointment
    {
        public int ID { get; set; }
        public static int id = 0;
        public String PatientName { get; set; }
        public String DoctorName { get; set; }
        public String Time { get; set; }
        public String Sickness { get; set; }
        public String appStatus { get; set; }
        public String costStatus { get; set; }
        public String appdate { get; set; }
        public String Cost { get; set; }


        public Appointment(String time, String patientname, String doctorname,  String sickness,String Appstatus,String cost, String coststatus, String Appdate ) {
            ID = id++;
            Time = time;
            PatientName = patientname;
            DoctorName = doctorname;
            Time = time;
            Sickness = sickness;
            appStatus = Appstatus;
            Cost = cost;
            costStatus = coststatus;
            appdate = Appdate;


        }

        public static double costcal(String cost) {
            double tax = 8;
            double calamt = 0.0;
            calamt = tax * Convert.ToDouble(cost);

            return calamt;
        }
    }
}
