using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EpigraphicElement
{
    public long Id { get; set; }

    public int? UsNum { get; set; }

    public int? IdObj { get; set; }

    public string? Material { get; set; }

    public string? OrigText { get; set; }

    public string? TransText { get; set; }

    public string? Gaps { get; set; }

    public string? Reuse { get; set; }

    public string? FabTechnique { get; set; }

    public string? TextLayout { get; set; }

    public string? Guidelines { get; set; }

    public string? Margins { get; set; }

    public string? LineSpacing { get; set; }

    public string? WritingTipology { get; set; }

    public string? Abbreviations { get; set; }

    public string? Connections { get; set; }

    public string? InterpunctionSeparationSystems { get; set; }

    public string? PaleographicComment { get; set; }

    public string? Decorations { get; set; }

    public string? DescrDecor { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public bool? DatingElement { get; set; }

    public string? ConsPlace { get; set; }

    public string? Ref { get; set; }

    public string? Edition { get; set; }

    public string? Notes { get; set; }

    public string? SheetAuthor { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<BoneObject> BoneObjects { get; set; } = new List<BoneObject>();

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<Glass> Glasses { get; set; } = new List<Glass>();

    public virtual ICollection<Metal> Metals { get; set; } = new List<Metal>();

    public virtual ICollection<Pottery> Potteries { get; set; } = new List<Pottery>();

    public virtual ICollection<StoneObject> StoneObjects { get; set; } = new List<StoneObject>();

    public virtual ICollection<WoodenObject> WoodenObjects { get; set; } = new List<WoodenObject>();
}
