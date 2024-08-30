using QLPM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAL.Repositories
{

    public class MedicalRecordRepository : GenericRepository<MedicalRecord>
    {
        public MedicalRecordRepository(AppDbContext context) : base(context) { }
    }
}
