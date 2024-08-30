using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPM.Common.DAL;
using QLPM.DAL.Models;

namespace QLPM.DAL.Repositories
{
    //public class MedicineRepository : GenericRep<QLPMContext, Medicine>
    //{
    //    public override Medicine Read(int id)
    //    {
    //        return All.FirstOrDefault(m => m.Id == id);
    //    }

    //    public override Medicine Read(string code)
    //    {
    //        return All.FirstOrDefault(m => m.Name == code);
    //    }
    //}
    public class MedicineRepository : GenericRepository<Medicine>
    {
        public MedicineRepository(AppDbContext context) : base(context) { }
    }
}
