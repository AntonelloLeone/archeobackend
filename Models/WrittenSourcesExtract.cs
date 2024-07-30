using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class WrittenSourcesExtract
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public long? WrittenSourceId { get; set; }

    public string? Subject { get; set; }

    public long? LocusListId { get; set; }

    public long? ZoneId { get; set; }

    public long? RoomId { get; set; }

    public long? TrenchId { get; set; }

    public long? IconographicSourceId { get; set; }

    public string? OrigText { get; set; }

    public string? TransText { get; set; }

    public string? Ref { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual IconographicSource? IconographicSource { get; set; }

    public virtual ICollection<IntangibleElement> IntangibleElements { get; set; } = new List<IntangibleElement>();

    public virtual LocusList? LocusList { get; set; }

    public virtual Room? Room { get; set; }

    public virtual Trench? Trench { get; set; }

    public virtual WrittenSource? WrittenSource { get; set; }

    public virtual ICollection<WrittenSourcesObject> WrittenSourcesObjects { get; set; } = new List<WrittenSourcesObject>();

    public virtual Zone? Zone { get; set; }
}
