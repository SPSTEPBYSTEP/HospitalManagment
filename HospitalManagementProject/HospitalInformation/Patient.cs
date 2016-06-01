using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformation
{
    public class Patient : Person
    {
        public String Address { get; set; }
        public String Phone { get; set; }
        public String DOB { get; set; }


        public Patient(String address, String phone, String dob, String fname, String lname,  String username,String password,String role) : base(fname, lname, username,password,role)
        {
            Address = address;
            Phone = phone;
            DOB = dob;


        }
       
       
    }
}
