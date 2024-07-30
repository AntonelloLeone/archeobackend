using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Pottery
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public long? SpecialFindId { get; set; }

    public string? PotteryClass { get; set; }

    public string? Production { get; set; }

    public string? Form { get; set; }

    public string? PotteryType { get; set; }

    public string? ClayType { get; set; }

    public string? FabTechnique { get; set; }

    public string? ExtCoating { get; set; }

    public string? IntCoating { get; set; }

    public bool? Intact { get; set; }

    public bool? Reconstr { get; set; }

    public int? Rim { get; set; }

    public int? Bottom { get; set; }

    public int? Handle { get; set; }

    public int? Beak { get; set; }

    public int? Grip { get; set; }

    public int? Body { get; set; }

    public int? TotFrag { get; set; }

    public decimal? WeightG { get; set; }

    public decimal? DiameterRimCm { get; set; }

    public decimal? DiameterBottomCm { get; set; }

    public decimal? MeasuresCm { get; set; }

    public string? Decorations { get; set; }

    public string? Description { get; set; }

    public bool? Epigraphics { get; set; }

    public string? DescrEp { get; set; }

    public long? EpigraphicElementId { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public bool? DatingElement { get; set; }

    public string? Provenance { get; set; }

    public long? ZoneId { get; set; }

    public long? RoomId { get; set; }

    public long? TrenchId { get; set; }

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
