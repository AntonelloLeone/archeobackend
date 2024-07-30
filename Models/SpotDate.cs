using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SpotDate
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public string? Definition { get; set; }

    public string? Period { get; set; }

    public string? Phase { get; set; }

    public int? TerminiusPost { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
