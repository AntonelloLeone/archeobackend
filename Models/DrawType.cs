using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DrawType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<ArchivalDrawing> ArchivalDrawings { get; set; } = new List<ArchivalDrawing>();

    public virtual ICollection<Drawing> Drawings { get; set; } = new List<Drawing>();

    public virtual ICollection<Locu> Locus { get; set; } = new List<Locu>();

    public virtual ICollection<LocusCoating> LocusCoatings { get; set; } = new List<LocusCoating>();

    public virtual ICollection<LocusWall> LocusWalls { get; set; } = new List<LocusWall>();
}
