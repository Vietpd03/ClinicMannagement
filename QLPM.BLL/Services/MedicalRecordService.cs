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
    public class MedicalRecordService
    {
        private readonly MedicalRecordRepository _repository;

        public MedicalRecordService(MedicalRecordRepository repository)
        {
            _repository = repository;
        }

        public SingleRsp GetAllMedicalRecords()
        {
            var res = new SingleRsp();
            res.Data = _repository.GetAll();
            return res;
        }

        public SingleRsp GetMedicalRecordById(int id)
        {
            var res = new SingleRsp();
            res.Data = _repository.GetById(id);
            return res;
        }

        public SingleRsp CreateMedicalRecord(MedicalRecord medicalRecord)
        {
            var res = new SingleRsp();
            _repository.Create(medicalRecord);
            res.Data = medicalRecord;
            return res;
        }

        public SingleRsp UpdateMedicalRecord(MedicalRecord medicalRecord)
        {
            var res = new SingleRsp();
            _repository.Update(medicalRecord);
            res.Data = medicalRecord;
            return res;
        }

        public SingleRsp DeleteMedicalRecord(int id)
        {
            var res = new SingleRsp();
            _repository.Delete(id);
            return res;
        }
    }
}
