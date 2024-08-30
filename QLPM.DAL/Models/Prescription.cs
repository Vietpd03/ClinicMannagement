using System;
using System.Collections.Generic;

namespace QLPM.DAL.Models;

public partial class Prescription
{
    public int PrescriptionId { get; set; }

    public int? RecordId { get; set; }

    public int? MedicineId { get; set; }

    public string? Dosage { get; set; }

    public string? Duration { get; set; }

    public virtual Medicine? Medicine { get; set; }

    public virtual MedicalRecord? Record { get; set; }
}
