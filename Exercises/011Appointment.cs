using System;
using System.Globalization;

namespace Exercism.Exercises {
    class Appointment {
        public static DateTime Schedule(string datetime) {
            return DateTime.Parse(datetime, CultureInfo.GetCultureInfo("en-US"));
        }

        public static bool HasPassed(DateTime appointmentDatetime) {
            return DateTime.Now > appointmentDatetime;
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDatetime) {
            return appointmentDatetime.Hour >= 12 && appointmentDatetime.Hour < 18;
        }

        public static string Description(DateTime appointmentDatetime) {
            return $"You have an appointment on {appointmentDatetime.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}.";
        }

        public static DateTime AnniversaryDate() {
            return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
        }

        public static void Executar() {
            Console.WriteLine(Appointment.Schedule("7/25/2019 13:45:00"));
            Console.WriteLine(Appointment.HasPassed(new DateTime(2023, 12, 31, 9, 0, 0)));
            Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0)));
            Console.WriteLine(Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0)));
            Console.WriteLine(Appointment.AnniversaryDate());
        }
    }
}
