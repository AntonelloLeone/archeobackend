using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Zone
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public string? Name { get; set; }

    public string? SpaceType { get; set; }

    public string? ZoneNum { get; set; }

    public int? PeriodStart { get; set; }

    public int? PeriodEnd { get; set; }

    public bool? EdCorbo { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<BoneObject> BoneObjects { get; set; } = new List<BoneObject>();

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<Coin> Coins { get; set; } = new List<Coin>();

    public virtual ICollection<Glass> Glasses { get; set; } = new List<Glass>();

    public virtual ICollection<Locu> Locus { get; set; } = new List<Locu>();

    public virtual ICollection<LocusCoating> LocusCoatings { get; set; } = new List<LocusCoating>();

    public virtual ICollection<LocusWall> LocusWalls { get; set; } = new List<LocusWall>();

    public virtual ICollection<Metal> Metals { get; set; } = new List<Metal>();

    public virtual ICollection<Pottery> Potteries { get; set; } = new List<Pottery>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<StoneObject> StoneObjects { get; set; } = new List<StoneObject>();

    public virtual ICollection<Trench> Trenches { get; set; } = new List<Trench>();

    public virtual ICollection<WoodenObject> WoodenObjects { get; set; } = new List<WoodenObject>();

    public virtual ICollection<WrittenSourcesExtract> WrittenSourcesExtracts { get; set; } = new List<WrittenSourcesExtract>();
}
