using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Patient
    {
        /*
        <summary>
        Declaracion de variables. Age es un valor numerico en caso de necesitar realizar calculos con el mismo a futuro
        </summary>
        */
        public string name {get ; set ;}
        public string id {get ; set ;}
        public string phoneNumber {get ; set;}
        public int age = 0;

        public Patient(String patientname, String patientid, String patientphone, Int16 patientage)
        {
            this.name = patientname;
            this.id = patientid;
            this.phoneNumber = patientphone;
            this.age = patientage;
        }
        /*
            <summary>
            Llamar validacion antes de crear objeto
            </summary>
            */
        public static Patient AddPatient(String patientname, String patientid, String patientphone, Int16 patientage)
        {
            Patient newpatient = new Patient(patientname, patientid, patientphone, patientage);
            if(!Validation.patientval(newpatient))
            {
                newpatient = null;
                Console.WriteLine("Patient was not created successfully, please check log");
            }
            return newpatient;
        }
    }
}