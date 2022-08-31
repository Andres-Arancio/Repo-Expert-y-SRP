using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Validation
    {
        /*
        <summary>
        Validar informacion de los pacientes
        </summary>
        */
        public static Boolean patientval(string patientname, string id, string phoneNumber, int age)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(patientname))
            {
                Console.WriteLine("Unable to add patient, 'name' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("Unable to add patient, 'id' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(phoneNumber))
            {
                Console.WriteLine("Unable to add patient, 'phone number' is required\n");
                isValid = false;
            }
            if (age == 0)
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
        /*
        <summary>
        Validar informacion de los doctores
        </summary>
        */
        public static Boolean doctorval(string docname, string specialization)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(docname))
            {
                Console.WriteLine("Unable to add doctor, 'name' is required\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(specialization))
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

        /*
        <summary>
        Validar informacion de los appointments
        El ID no se valida ya que es un atributo system-driven
        </summary>
        */
        public static Boolean appointmentval(DateTime appdate, String place)
        {
            Boolean isValid = true;
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