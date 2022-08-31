using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Doctor
    {
        /*
        <summary>
        Declaracion de variables
        </summary>
        */
        public string name {get ; set ;}
        public string specialization {get ; set ;}

        public Doctor(String doctorname, String doctorspec)
        {
            this.name = doctorname;
            this.specialization = doctorspec;
            
        }
        /*
        <summary>
        Llamar validacion antes de crear objeto
        </summary>
        */
        public static Doctor AddDoctor(String doctorname, String doctorspec)
        {
            Doctor newdoctor = new Doctor(doctorname, doctorspec);
            if(!Validation.doctorval(newdoctor))
            {
                newdoctor = null;
                Console.WriteLine("Doctor was not created successfully, please check log");
            }
            return newdoctor;
        }
    }
}