using QLPM.Common.DAL;
using QLPM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLPM.DAL.Repositories
{
    //public class PrescriptionRepository : GenericRep<QLPMContext, Medicine>
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

    public class PrescriptionRepository : GenericRepository<Prescription>
    {
        public PrescriptionRepository(AppDbContext context) : base(context) { }
    }
}
