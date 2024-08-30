using QLPM.Common.Req;
using QLPM.Common.Rsp;
using QLPM.DAL.Models;
using QLPM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.BLL.Services
{
   
    public class PatientService
    {
        private readonly PatientRepository _repository;
        private readonly AppointmentRepository _appointmentRepository;

        public PatientService(PatientRepository repository, AppointmentRepository appointmentRepository)
        {
            _repository = repository;
            _appointmentRepository = appointmentRepository;
        }

        public SingleRsp GetAllPatients()
        {
            var res = new SingleRsp();
            res.Data = _repository.GetAll();
            return res;
        }

        public SingleRsp GetPatientById(int id)
        {
            var res = new SingleRsp();
            res.Data = _repository.GetById(id);
            return res;
        }

        public SingleRsp CreatePatient(Patient patient)
        {
            var res = new SingleRsp();
            _repository.Create(patient);
            res.Data = patient;
            return res;
        }

        public SingleRsp UpdatePatient(Patient patient)
        {
            var res = new SingleRsp();
            _repository.Update(patient);
            res.Data = patient;
            return res;
        }

        public SingleRsp DeletePatient(int id)
        {
            var res = new SingleRsp();
            _repository.Delete(id);
            return res;
        }

        //public SingleRsp RegisterAppointment(AppointmentReq req)
        //{
        //    var res = new SingleRsp();

        //    if (_appointmentRepository.IsAppointmentExist(req.PatientId, req.DoctorId, req.AppointmentDate))
        //    {
        //        res.SetError("This appointment already exists.");
        //        return res;
        //    }

        //    var appointment = new Appointment
        //    {
        //        PatientId = req.PatientId,
        //        DoctorId = req.DoctorId,
        //        AppointmentDate = req.AppointmentDate,
        //        Status = "Pending"
        //    };

        //    _appointmentRepository.Create(appointment);
        //    res.Data = appointment;
        //    return res;
        //}

        //public SingleRsp GetAvailableSchedule(int doctorId, DateTime date)
        //{
        //    var res = new SingleRsp();
        //    var appointments = _appointmentRepository.GetDoctorAppointmentsByDate(doctorId, date);
        //    var availableSlots = new List<DateTime>();

        //    // Assuming doctor works from 9 AM to 5 PM with 1-hour slots
        //    for (int hour = 9; hour <= 17; hour++)
        //    {
        //        var slot = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
        //        if (!appointments.Any(a => a.AppointmentDate == slot))
        //        {
        //            availableSlots.Add(slot);
        //        }
        //    }

        //    res.Data = availableSlots;
        //    return res;
        //}

        public SingleRsp RegisterAppointment(AppointmentReq req)
        {
            var res = new SingleRsp();
            var appointment = new Appointment
            {
                DoctorId = req.DoctorId,
                PatientId = req.PatientId,
                AppointmentDate = req.AppointmentDate,
                Reason = req.Reason
            };
            _appointmentRepository.Create(appointment);
            res.Data = appointment;
            return res;
        }

        public SingleRsp GetAvailableSchedule(int doctorId, DateTime date)
        {
            var res = new SingleRsp();
            var appointments = _appointmentRepository.GetAll()
                .Where(a => a.DoctorId == doctorId && a.AppointmentDate.Date == date.Date)
                .ToList();
            res.Data = appointments;
            return res;
        }
    }

}
