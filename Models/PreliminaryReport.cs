using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class PreliminaryReport
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public string? Material { get; set; }

    public string? ReportClass { get; set; }

    public bool? Intact { get; set; }

    public int? Rim { get; set; }

    public int? Bottom { get; set; }

    public int? Handle { get; set; }

    public int? Beak { get; set; }

    public int? Grip { get; set; }

    public int? Body { get; set; }

    public int? TotFrag { get; set; }

    public string? Notes { get; set; }

    public bool? DatingElement { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
