using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformation
{
    public class Person
    {
        public int PersonId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
       
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
        private static int id = 0;

        public Person( String Fname, String Lname, String userName, String password,String role)
        {
            PersonId = id++;
            FirstName = Fname;
            LastName = Lname;
            
            UserName = userName;
            Password = password;
            Role = role;
        }


    }
}
