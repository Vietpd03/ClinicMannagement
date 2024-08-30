using System;
using QLPM.Common.BLL;
using QLPM.Common.Rsp;
using QLPM.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM.DAL.Repositories;

namespace QLPM.BLL.Services
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _repository;

        public AppointmentService(AppointmentRepository repository)
        {
            _repository = repository;
        }

        public SingleRsp GetAllAppointments()
        {
            var res = new SingleRsp();
            res.Data = _repository.GetAll();
            return res;
        }

        public SingleRsp GetAppointmentById(int id)
        {
            var res = new SingleRsp();
            res.Data = _repository.GetById(id);
            return res;
        }

        public SingleRsp CreateAppointment(Appointment appointment)
        {
            var res = new SingleRsp();
            _repository.Create(appointment);
            res.Data = appointment;
            return res;
        }

        public SingleRsp UpdateAppointment(Appointment appointment)
        {
            var res = new SingleRsp();
            _repository.Update(appointment);
            res.Data = appointment;
            return res;
        }

        public SingleRsp DeleteAppointment(int id)
        {
            var res = new SingleRsp();
            _repository.Delete(id);
            return res;
        }
    }
}
