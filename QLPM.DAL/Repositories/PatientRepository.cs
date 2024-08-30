using QLPM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAL.Repositories
{
    public class PatientRepository : GenericRepository<Patient>
    {
        public PatientRepository(AppDbContext context) : base(context) { }
    }
}
