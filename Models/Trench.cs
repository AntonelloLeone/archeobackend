using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Trench
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public string? Definition { get; set; }

    public string? Location { get; set; }

    public long? ZoneId { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public string? Bibliography { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<BiblioLink> BiblioLinks { get; set; } = new List<BiblioLink>();

    public virtual ICollection<BoneObject> BoneObjects { get; set; } = new List<BoneObject>();

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<Coin> Coins { get; set; } = new List<Coin>();

    public virtual ICollection<Glass> Glasses { get; set; } = new List<Glass>();

    public virtual ICollection<Locu> Locus { get; set; } = new List<Locu>();

    public virtual ICollection<LocusCoating> LocusCoatings { get; set; } = new List<LocusCoating>();

    public virtual ICollection<LocusList> LocusLists { get; set; } = new List<LocusList>();

    public virtual ICollection<LocusWall> LocusWalls { get; set; } = new List<LocusWall>();

    public virtual ICollection<Metal> Metals { get; set; } = new List<Metal>();

    public virtual ICollection<Pottery> Potteries { get; set; } = new List<Pottery>();

    public virtual ICollection<StoneObject> StoneObjects { get; set; } = new List<StoneObject>();

    public virtual ICollection<WoodenObject> WoodenObjects { get; set; } = new List<WoodenObject>();

    public virtual ICollection<WrittenSourcesExtract> WrittenSourcesExtracts { get; set; } = new List<WrittenSourcesExtract>();

    public virtual Zone? Zone { get; set; }
}
