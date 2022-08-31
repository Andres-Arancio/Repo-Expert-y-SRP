using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc1 = Doctor.AddDoctor("Armand","Pediatra");
            Doctor doc2 = Doctor.AddDoctor("", "Odontologo");

            Patient pat1 = Patient.AddPatient("Steven Johnson", "986782342", "5555-555-555", 12);
            Patient pat2 = Patient.AddPatient("Ralf Manson", "", "5555-555-555", 18);

            AppointmentService.AddAppointment(DateTime.Now, "Wall Street", pat1, doc1);
            AppointmentService.AddAppointment(DateTime.Now, "Queen Street", pat2, doc2);

            /*
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */
        }
    }
}