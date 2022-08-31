using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc1 = new Doctor("Armand","Pediatra");
            Doctor doc2 = new Doctor("", "Odontologo");

            Patient pat1 = new Patient("Steven Johnson", "986782342", "5555-555-555", 12);
            Patient pat2 = new Patient("Ralf Manson", "", "5555-555-555", 18);

            AppointmentService app1 = new AppointmentService(DateTime.Now, "Wall Street", pat1, doc1);
            AppointmentService app2 = new AppointmentService(DateTime.Now, "Queen Street", pat2, doc2);

            /*
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */
        }
    }
}