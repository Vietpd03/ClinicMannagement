using QLPM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM.DAL.Repositories
{

    public class DoctorRepository : GenericRepository<Doctor>
    {
        public DoctorRepository(AppDbContext context) : base(context) { }
    }
}
