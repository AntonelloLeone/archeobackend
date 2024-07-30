using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class GeneralBibliography
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public string? Author { get; set; }

    public int? Year { get; set; }

    public string? Abbreviation { get; set; }

    public string? Citation { get; set; }

    public string? Serial { get; set; }

    public string? Title { get; set; }

    public string? Index { get; set; }

    public string? Subject { get; set; }

    public string? Review { get; set; }

    public string? Illustrations { get; set; }

    public string? Library { get; set; }

    public string? TypeProduct { get; set; }

    public string? Editor { get; set; }

    public string? OnlineResources { get; set; }

    public string? City { get; set; }

    public string? Language { get; set; }

    public string? Publisher { get; set; }

    public string? Typographer { get; set; }

    public string? CitedBy { get; set; }

    public string? Status { get; set; }

    public bool? Consulted { get; set; }

    public string? Notes { get; set; }

    public string? Isbn { get; set; }

    public string? Abstract { get; set; }

    public string? Edition { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<ArchivalDrawing> ArchivalDrawings { get; set; } = new List<ArchivalDrawing>();

    public virtual ICollection<BiblioLink> BiblioLinks { get; set; } = new List<BiblioLink>();

    public virtual ICollection<BoneObject> BoneObjects { get; set; } = new List<BoneObject>();

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<Coin> Coins { get; set; } = new List<Coin>();

    public virtual ICollection<Glass> Glasses { get; set; } = new List<Glass>();

    public virtual ICollection<IconographicSource> IconographicSources { get; set; } = new List<IconographicSource>();

    public virtual ICollection<IntangibleElement> IntangibleElements { get; set; } = new List<IntangibleElement>();

    public virtual ICollection<Metal> Metals { get; set; } = new List<Metal>();

    public virtual ICollection<PhotographicSource> PhotographicSources { get; set; } = new List<PhotographicSource>();

    public virtual ICollection<Pottery> Potteries { get; set; } = new List<Pottery>();

    public virtual ICollection<StoneObject> StoneObjects { get; set; } = new List<StoneObject>();

    public virtual ICollection<WoodenObject> WoodenObjects { get; set; } = new List<WoodenObject>();
}
