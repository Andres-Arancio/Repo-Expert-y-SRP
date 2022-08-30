using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Validation
    {
        public Boolean isValid {get ; set ;}

        public Boolean patientval(Patient newPatient)
        {
            isValid = true;
            if (string.IsNullOrEmpty(newPatient.name))
            {
                Console.WriteLine("Unable to add patient, 'name' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(newPatient.id))
            {
                Console.WriteLine("Unable to add patient, 'id' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(newPatient.phoneNumber))
            {
                Console.WriteLine("Unable to add patient, 'phone number' is required\n");
                isValid = false;
            }
            if (newPatient.age == null)
            {
                Console.WriteLine("Unable to add patient, 'age' is required\n");
                isValid = false;
            }
            if (isValid == true)
            {
                Console.WriteLine("Patient validated successfully");
            }

            return isValid;
        }

        public Boolean doctorval(Doctor newDoctor)
        {
            isValid = true;
            if (string.IsNullOrEmpty(newDoctor.name))
            {
                Console.WritelIne("Unable to add doctor, 'name' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(newDoctor.specialization))
            {
                Console.WriteLine("Unable to add doctor, 'specialization' is required\n");
                isValid = false;
            }
            if (isValid == true)
            {
                Console.WriteLine("Doctor validated successfully");
            }

            return isValid;
        }

        public Boolean appointmentval(int appid, DateTime appdate, String place)
        {
            isValid = true;
            if (appid == null)
            {
                Console.WriteLine("Unable to schedule appointment, 'id' is empty\n");
                isValid = false;
            }
            if (appdate == null)
            {
                Console.WriteLine("Unable to schedule appointment, 'date' is empty\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(place))
            {
                Console.WriteLine("Unable to schedule appointment, 'Appointment Place' is required\n");
                isValid = false;
            }
            if (isValid == false)
            {
                Console.WriteLine("Appointment validated successfully");
            }

            return isValid;
        }
    }
}