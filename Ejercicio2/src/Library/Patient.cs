using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Patient
    {
        public string name {get ; set ;}
        public string id {get ; set ;}
        public string phoneNumber {get ; set;}
        public int age {get ; set ;}

        public Patient(String patientname, String patientid, String patientphone, Int16 patientage)
        {
            this.name = patientname;
            this.id = patientid;
            this.phoneNumber = patientphone;
            this.age = patientage;
        }
    }
}