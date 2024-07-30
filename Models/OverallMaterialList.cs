using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class OverallMaterialList
{
    public long Id { get; set; }

    public string? IdFinds { get; set; }

    public string? IdSf { get; set; }

    public string? Area { get; set; }

    public string? Locus { get; set; }

    public string? Basket { get; set; }

    public string? Material { get; set; }

    public string? Definition { get; set; }

    public string? Specifications { get; set; }

    public bool? Photographed { get; set; }

    public bool? Drawed { get; set; }

    public bool? Filed { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
