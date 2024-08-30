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
   
    public class DoctorService
    {
        private readonly DoctorRepository _repository;
        private readonly AppointmentRepository _appointmentRepository;

        public DoctorService(DoctorRepository repository, AppointmentRepository appointmentRepository)
        {
            _repository = repository;
            _appointmentRepository = appointmentRepository;
        }

        public SingleRsp GetAllDoctors()
        {
            var res = new SingleRsp();
            res.Data = _repository.GetAll();
            return res;
        }

        public SingleRsp GetDoctorById(int id)
        {
            var res = new SingleRsp();
            res.Data = _repository.GetById(id);
            return res;
        }

        public SingleRsp CreateDoctor(Doctor doctor)
        {
            var res = new SingleRsp();
            _repository.Create(doctor);
            res.Data = doctor;
            return res;
        }

        public SingleRsp UpdateDoctor(Doctor doctor)
        {
            var res = new SingleRsp();
            _repository.Update(doctor);
            res.Data = doctor;
            return res;
        }

        public SingleRsp DeleteDoctor(int id)
        {
            var res = new SingleRsp();
            _repository.Delete(id);
            return res;
        }

        public SingleRsp GetAvailableSchedule(int doctorId, DateTime date)
        {
            var res = new SingleRsp();
            var appointments = _appointmentRepository.GetDoctorAppointmentsByDate(doctorId, date);
            var availableSlots = new List<DateTime>();

            // Assuming doctor works from 9 AM to 5 PM with 1-hour slots
            for (int hour = 9; hour <= 17; hour++)
            {
                var slot = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                if (!appointments.Any(a => a.AppointmentDate == slot))
                {
                    availableSlots.Add(slot);
                }
            }

            res.Data = availableSlots;
            return res;
        }
    }

}
