using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformation
{
   public class Doctor:Person
    {
        public String Type { get; set; }
        public Doctor(String type,String fname, String lname,  String username, String password, String role) : base(fname, lname,  username, password,role)
        { Type = type; }
    }
}
