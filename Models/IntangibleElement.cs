using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class IntangibleElement
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public string? Definition { get; set; }

    public string? Calendar { get; set; }

    public string? Zone { get; set; }

    public string? Location { get; set; }

    public string? ShortDescr { get; set; }

    public string? UsNum { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public long? WrittenSourcesExtractId { get; set; }

    public long? WrittenSourcesObjectId { get; set; }

    public long? WrittenSourceId { get; set; }

    public long? PhotographicSourceId { get; set; }

    public long? GeneralBibliographyId { get; set; }

    public long? PhotographId { get; set; }

    public long? IconographicSourceId { get; set; }

    public long? ArchivalDrawingId { get; set; }

    public long? DrawingId { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ArchivalDrawing? ArchivalDrawing { get; set; }

    public virtual ICollection<BiblioLink> BiblioLinks { get; set; } = new List<BiblioLink>();

    public virtual Drawing? Drawing { get; set; }

    public virtual GeneralBibliography? GeneralBibliography { get; set; }

    public virtual IconographicSource? IconographicSource { get; set; }

    public virtual Photograph? Photograph { get; set; }

    public virtual PhotographicSource? PhotographicSource { get; set; }

    public virtual WrittenSource? WrittenSource { get; set; }

    public virtual WrittenSourcesExtract? WrittenSourcesExtract { get; set; }

    public virtual WrittenSourcesObject? WrittenSourcesObject { get; set; }
}
