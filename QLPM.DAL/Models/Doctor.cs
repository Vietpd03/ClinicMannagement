using System;
using System.Collections.Generic;

namespace QLPM.DAL.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public int? UserId { get; set; }

    public string Specialty { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual User? User { get; set; }

    //public ICollection<Appointment> Appointments { get; set; }
}
