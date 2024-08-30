using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM.Common.DAL;
using QLPM.DAL.Models;

namespace QLPM.DAL.Repositories
{
    //public class AppointmentRepository : GenericRepository<Appointment>
    //{
    //    public AppointmentRepository(ClinicContext context) : base(context) { }

    //    public IEnumerable<Appointment> GetAppointmentsByDoctorId(int doctorId)
    //    {
    //        return _context.Appointments.Where(a => a.DoctorId == doctorId).ToList();
    //    }

    //    public void UpdateAppointment(Appointment appointment)
    //    {
    //        var existingAppointment = _context.Appointments.Find(appointment.AppointmentId);
    //        if (existingAppointment != null)
    //        {
    //            existingAppointment.PatientId = appointment.PatientId;
    //            existingAppointment.DoctorId = appointment.DoctorId;
    //            existingAppointment.AppointmentDate = appointment.AppointmentDate;
    //            existingAppointment.Status = appointment.Status;
    //            _context.SaveChanges();
    //        }
    //    }

    //    public void DeleteAppointment(int appointmentId)
    //    {
    //        var appointment = _context.Appointments.Find(appointmentId);
    //        if (appointment != null)
    //        {
    //            _context.Appointments.Remove(appointment);
    //            _context.SaveChanges();
    //        }
    //    }
    //}
    //public class AppointmentRepository : GenericRepository<Appointment>
    //{
    //    public AppointmentRepository(AppDbContext context) : base(context) { }
    //}
    public class AppointmentRepository : GenericRepository<Appointment>
    {
        public AppointmentRepository(AppDbContext context) : base(context) { }

        public bool IsAppointmentExist(int patientId, int doctorId, DateTime appointmentDate)
        {
            return _context.Appointments.Any(a => a.PatientId == patientId && a.DoctorId == doctorId && a.AppointmentDate == appointmentDate);
        }

        public IEnumerable<Appointment> GetDoctorAppointmentsByDate(int doctorId, DateTime date)
        {
            return _context.Appointments.Where(a => a.DoctorId == doctorId && a.AppointmentDate.Date == date.Date).ToList();
        }
    }
}
