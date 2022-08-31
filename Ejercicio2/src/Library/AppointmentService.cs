using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /*
        <summary>
        Declaracion de variables. Counter se utiliza junto a ID para asegurar un numero unico de appointments
        </summary>
        */
        private static int counter = 1;
        public int id {get ; set ;}
        public DateTime date {get ; set ;}
        public string appointmentPlace {get ; set ;}
        public Patient appointmentPatient {get ; set ;}
        public Doctor appointmentDoctor {get ; set ;}

        /*
        <note>
        Faltan hacer las validaciones
        </note>
        */
        public AppointmentService(DateTime appdate, String place, Patient appPatient, Doctor appDoc)
        {
            this.id = counter;
            this.date = appdate;
            this.appointmentPlace = place;
            this.appointmentPatient = appPatient;
            this.appointmentDoctor = appDoc;
            counter++; 
        }
        /*
        <summary>
        Llamar validacion antes de crear objeto
        </summary>
        */
        public static AppointmentService AddAppointment(DateTime appdate, String place, Patient appPatient, Doctor appDoc)
        {
            AppointmentService newapp = new AppointmentService(appdate, place, appPatient, appDoc);
            if(!Validation.appointmentval(newapp))
            {
                newapp = null;
                Console.WriteLine("Appointment was not created successfully, please check log");
            }
            return newapp;
        }

        /*
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, 
        string doctorName)
        {  
            <observation>
            Siguiendo SRP y Expert
            El codigo repite el proceso de validacion cuando este podria ser una clase en si misma
            La informacion de id, name y phone number deberian ser atributos de un objeto "Patient" al que se le podrian agregar mas atributos como "age"
            La informacion de doctor name deberia ser atributo de un objeto "Doctor" al que se le podria agregar mas atributos como "specialization"
            El appointment en si mismo deberia tener un id unico
            </observation>
            
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }
        */

    }
}