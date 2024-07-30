using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class WrittenSource
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? SourceType { get; set; }

    public string? Manuscript { get; set; }

    public long? BiblioCriticalEditionId { get; set; }

    public long? BiblioOriginalTextId { get; set; }

    public long? BiblioTransTextId { get; set; }

    public string? ChronMin { get; set; }

    public string? ChronMax { get; set; }

    public string? OrigText { get; set; }

    public string? TransText { get; set; }

    public string? Ref { get; set; }

    public string? Notes { get; set; }

    public string? Annex { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<IntangibleElement> IntangibleElements { get; set; } = new List<IntangibleElement>();

    public virtual ICollection<WrittenSourcesExtract> WrittenSourcesExtracts { get; set; } = new List<WrittenSourcesExtract>();

    public virtual ICollection<WrittenSourcesObject> WrittenSourcesObjects { get; set; } = new List<WrittenSourcesObject>();
}
