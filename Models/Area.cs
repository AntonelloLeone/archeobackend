using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Area
{
    public long Id { get; set; }

    public string? Definition { get; set; }

    public string? Location { get; set; }

    public long? ZoneId { get; set; }

    public DateOnly? DateOfStart { get; set; }

    public DateOnly? DateOfEnd { get; set; }

    public string? Bibliography { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Coin> Coins { get; set; } = new List<Coin>();

    public virtual ICollection<Drawing> Drawings { get; set; } = new List<Drawing>();

    public virtual ICollection<Locu> Locus { get; set; } = new List<Locu>();

    public virtual ICollection<LocusCoating> LocusCoatings { get; set; } = new List<LocusCoating>();

    public virtual ICollection<LocusList> LocusLists { get; set; } = new List<LocusList>();

    public virtual ICollection<LocusWall> LocusWalls { get; set; } = new List<LocusWall>();

    public virtual ICollection<PhotographicSource> PhotographicSources { get; set; } = new List<PhotographicSource>();

    public virtual ICollection<Photograph> Photographs { get; set; } = new List<Photograph>();

    public virtual Zone? Zone { get; set; }
}
