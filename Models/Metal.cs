using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Metal
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public string? Tsdbcode { get; set; }

    public long? SpecialFindId { get; set; }

    public int? ClassMetal { get; set; }

    public int? SubclassMetal { get; set; }

    public int? DefObject { get; set; }

    public string? Material { get; set; }

    public string? SpecMaterial { get; set; }

    public bool? Intact { get; set; }

    public bool? Reconstr { get; set; }

    public int? TotFrag { get; set; }

    public decimal? WeightG { get; set; }

    public decimal? HeightCm { get; set; }

    public decimal? WidthCm { get; set; }

    public decimal? ThicknessCm { get; set; }

    public string? Decorations { get; set; }

    public string? DescrDecor { get; set; }

    public bool? Epigraphics { get; set; }

    public string? DescrEp { get; set; }

    public long? EpigraphicElementId { get; set; }

    public string? Description { get; set; }

    public string? DesignatedUse { get; set; }

    public string? Provenance { get; set; }

    public long? ZoneId { get; set; }

    public long? RoomId { get; set; }

    public long? TrenchId { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public bool? DatingElement { get; set; }

    public string? ConsPlace { get; set; }

    public string? Ref { get; set; }

    public long? WrittenSourcesObjectId { get; set; }

    public long? IconographicSourceId { get; set; }

    public long? GeneralBibliographyId { get; set; }

    public long? PhotographicSourceId { get; set; }

    public long? PhotographId { get; set; }

    public long? ArchivalSourceId { get; set; }

    public long? ArchivalDrawingId { get; set; }

    public long? DrawingId { get; set; }

    public string? Notes { get; set; }

    public string? SheetAuthor { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ArchivalDrawing? ArchivalDrawing { get; set; }

    public virtual ArchivalSource? ArchivalSource { get; set; }

    public virtual Drawing? Drawing { get; set; }

    public virtual EpigraphicElement? EpigraphicElement { get; set; }

    public virtual GeneralBibliography? GeneralBibliography { get; set; }

    public virtual IconographicSource? IconographicSource { get; set; }

    public virtual Photograph? Photograph { get; set; }

    public virtual PhotographicSource? PhotographicSource { get; set; }

    public virtual Room? Room { get; set; }

    public virtual SpecialFind? SpecialFind { get; set; }

    public virtual Trench? Trench { get; set; }

    public virtual WrittenSourcesObject? WrittenSourcesObject { get; set; }

    public virtual Zone? Zone { get; set; }
}
