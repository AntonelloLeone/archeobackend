﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SpecialFind
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public string? IdObj { get; set; }

    public string? Material { get; set; }

    public string? Definition { get; set; }

    public string? Description { get; set; }

    public string? Chronology { get; set; }

    public string? Image { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? LocationTsNumber { get; set; }

    public string? AbsoluteElevation { get; set; }

    public virtual ICollection<BoneObject> BoneObjects { get; set; } = new List<BoneObject>();

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<Coin> Coins { get; set; } = new List<Coin>();

    public virtual ICollection<Glass> Glasses { get; set; } = new List<Glass>();

    public virtual ICollection<Metal> Metals { get; set; } = new List<Metal>();

    public virtual ICollection<Pottery> Potteries { get; set; } = new List<Pottery>();

    public virtual ICollection<StoneObject> StoneObjects { get; set; } = new List<StoneObject>();

    public virtual ICollection<WoodenObject> WoodenObjects { get; set; } = new List<WoodenObject>();
}
