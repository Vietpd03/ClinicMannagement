using QLPM.Common.BLL;
using QLPM.Common.Rsp;
using QLPM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM.DAL.Repositories;

namespace QLPM.BLL.Services
{
    public class MedicineService
    {
        private readonly MedicineRepository _repository;

        public MedicineService(MedicineRepository repository)
        {
            _repository = repository;
        }

        public SingleRsp GetAllMedicines()
        {
            var res = new SingleRsp();
            res.Data = _repository.GetAll();
            return res;
        }

        public SingleRsp GetMedicineById(int id)
        {
            var res = new SingleRsp();
            res.Data = _repository.GetById(id);
            return res;
        }

        public SingleRsp CreateMedicine(Medicine medicine)
        {
            var res = new SingleRsp();
            _repository.Create(medicine);
            res.Data = medicine;
            return res;
        }

        public SingleRsp UpdateMedicine(Medicine medicine)
        {
            var res = new SingleRsp();
            _repository.Update(medicine);
            res.Data = medicine;
            return res;
        }

        public SingleRsp DeleteMedicine(int id)
        {
            var res = new SingleRsp();
            _repository.Delete(id);
            return res;
        }
    }
}
