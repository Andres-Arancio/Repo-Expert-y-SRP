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
        public static Boolean patientval(Patient newPatient)
        {
            Boolean isValid = true;
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
            if (newPatient.age == 0)
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
        public static Boolean doctorval(Doctor newDoctor)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(newDoctor.name))
            {
                Console.WriteLine("Unable to add doctor, 'name' is required\n");
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

        /*
        <summary>
        Validar informacion de los appointments
        El ID no se valida ya que es un atributo system-driven
        </summary>
        */
        public static Boolean appointmentval(AppointmentService newAppointment)
        {
            Boolean isValid = true;
            if (newAppointment.date == null)
            {
                Console.WriteLine("Unable to schedule appointment, 'date' is empty\n");
                isValid = false;
            }
            if (string.IsNullOrEmpty(newAppointment.appointmentPlace))
            {
                Console.WriteLine("Unable to schedule appointment, 'Appointment Place' is required\n");
                isValid = false;
            }
            if (newAppointment.appointmentDoctor == null)
            {
                Console.WriteLine("Unable to schedule appointment, 'Appointment Doctor' is required\n");
                isValid = false;
            }
            if (newAppointment.appointmentPatient == null)
            {
                Console.WriteLine("Unable to schedule appointment, 'Appointment Patient' is required\n");
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