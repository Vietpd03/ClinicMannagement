using System;
using System.Collections.Generic;

namespace QLPM.DAL.Models;

public partial class Patient
{
    public int PatientId { get; set; }

    public int? UserId { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual User? User { get; set; }
}
