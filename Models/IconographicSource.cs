using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class IconographicSource
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public string? Name { get; set; }

    public string? Author { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public string? Provenance { get; set; }

    public string? Type1 { get; set; }

    public string? Type2 { get; set; }

    public string? Subject { get; set; }

    public string? ShortDescr { get; set; }

    public string? CurrentLocation { get; set; }

    public long? GeneralBibliographyId { get; set; }

    public string? Zone { get; set; }

    public string? Bibliography { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<BiblioLink> BiblioLinks { get; set; } = new List<BiblioLink>();

    public virtual ICollection<BoneObject> BoneObjects { get; set; } = new List<BoneObject>();

    public virtual ICollection<Brick> Bricks { get; set; } = new List<Brick>();

    public virtual ICollection<Coin> Coins { get; set; } = new List<Coin>();

    public virtual GeneralBibliography? GeneralBibliography { get; set; }

    public virtual ICollection<Glass> Glasses { get; set; } = new List<Glass>();

    public virtual ICollection<IntangibleElement> IntangibleElements { get; set; } = new List<IntangibleElement>();

    public virtual ICollection<Metal> Metals { get; set; } = new List<Metal>();

    public virtual ICollection<Pottery> Potteries { get; set; } = new List<Pottery>();

    public virtual ICollection<StoneObject> StoneObjects { get; set; } = new List<StoneObject>();

    public virtual ICollection<WoodenObject> WoodenObjects { get; set; } = new List<WoodenObject>();

    public virtual ICollection<WrittenSourcesExtract> WrittenSourcesExtracts { get; set; } = new List<WrittenSourcesExtract>();
}
