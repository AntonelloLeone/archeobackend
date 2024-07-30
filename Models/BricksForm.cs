using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BricksForm
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<LocusWall> LocusWalls { get; set; } = new List<LocusWall>();
}
