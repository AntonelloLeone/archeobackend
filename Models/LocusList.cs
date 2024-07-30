using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class LocusList
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public string? UsType { get; set; }

    public string? SheetAuthor { get; set; }

    public long? TrenchId { get; set; }

    public string? Definition { get; set; }

    public string? UsLocation { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? AreaId { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<BiblioLink> BiblioLinks { get; set; } = new List<BiblioLink>();

    public virtual Trench? Trench { get; set; }

    public virtual ICollection<WrittenSourcesExtract> WrittenSourcesExtracts { get; set; } = new List<WrittenSourcesExtract>();
}
