using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string name {get ; set ;}
        public string specialization {get ; set ;}

        public Doctor(String doctorname, String doctorspec)
        {
            if(Validation.doctorval(doctorname, doctorspec))
            {
                this.name = doctorname;
                this.specialization = doctorspec;
            }
            else
            {
                Console.WriteLine("Unable to add doctor.\n");
            }
        }
    }
}