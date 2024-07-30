using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Room
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public int? RoomNum { get; set; }

    public string? SpaceType { get; set; }

    public int? PeriodStart { get; set; }

    public int? PeriodEnd { get; set; }

    public long? ZoneId { get; set; }

    public bool? EdCorbo { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<BoneObject> BoneObjects { get; set; } = new List<BoneObject>();

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<Coin> Coins { get; set; } = new List<Coin>();

    public virtual ICollection<Glass> Glasses { get; set; } = new List<Glass>();

    public virtual ICollection<LocusCoating> LocusCoatings { get; set; } = new List<LocusCoating>();

    public virtual ICollection<LocusWall> LocusWalls { get; set; } = new List<LocusWall>();

    public virtual ICollection<Metal> Metals { get; set; } = new List<Metal>();

    public virtual ICollection<Pottery> Potteries { get; set; } = new List<Pottery>();

    public virtual ICollection<StoneObject> StoneObjects { get; set; } = new List<StoneObject>();

    public virtual ICollection<WoodenObject> WoodenObjects { get; set; } = new List<WoodenObject>();

    public virtual ICollection<WrittenSourcesExtract> WrittenSourcesExtracts { get; set; } = new List<WrittenSourcesExtract>();

    public virtual Zone? Zone { get; set; }
}
