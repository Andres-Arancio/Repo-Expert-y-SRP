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
            /*
            <summary>
            Llamar validacion antes de crear objeto
            </summary>
            */
            if(Validation.patientval(patientname, patientid, patientphone, patientage))
            {
                this.name = patientname;
                this.id = patientid;
                this.phoneNumber = patientphone;
                this.age = patientage;
            }
            else
            {
                Console.WriteLine("Unable to add patient.\n");
            }
        }
    }
}