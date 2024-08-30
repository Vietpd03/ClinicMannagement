using QLPM.Common.BLL;
using QLPM.Common.Rsp;
using QLPM.DAL.Models;
using QLPM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM.DAL.Repositories;

namespace QLPM.BLL.Services
{
    public class PrescriptionService
    {
        private readonly PrescriptionRepository _repository;

        public PrescriptionService(PrescriptionRepository repository)
        {
            _repository = repository;
        }

        public SingleRsp GetAllPrescriptions()
        {
            var res = new SingleRsp();
            res.Data = _repository.GetAll();
            return res;
        }

        public SingleRsp GetPrescriptionById(int id)
        {
            var res = new SingleRsp();
            res.Data = _repository.GetById(id);
            return res;
        }

        public SingleRsp CreatePrescription(Prescription prescription)
        {
            var res = new SingleRsp();
            _repository.Create(prescription);
            res.Data = prescription;
            return res;
        }

        public SingleRsp UpdatePrescription(Prescription prescription)
        {
            var res = new SingleRsp();
            _repository.Update(prescription);
            res.Data = prescription;
            return res;
        }

        public SingleRsp DeletePrescription(int id)
        {
            var res = new SingleRsp();
            _repository.Delete(id);
            return res;
        }
    }
}
