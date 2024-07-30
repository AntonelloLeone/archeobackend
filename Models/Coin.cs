using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Coin
{
    public long Id { get; set; }

    public long? SpecialFindId { get; set; }

    public string? Site { get; set; }

    public long? AreaId { get; set; }

    public long? ZoneId { get; set; }

    public long? RoomId { get; set; }

    public long? TrenchId { get; set; }

    public string? Material { get; set; }

    public string? SpecMaterial { get; set; }

    public bool? Intact { get; set; }

    public bool? Restored { get; set; }

    public int? TotFrag { get; set; }

    public decimal? HeightMm { get; set; }

    public decimal? WidthMm { get; set; }

    public decimal? DiameterMm { get; set; }

    public decimal? ThicknessMm { get; set; }

    public decimal? WeightG { get; set; }

    public string? CoinagePosition { get; set; }

    public string? ObverseDescr { get; set; }

    public string? ObverseLegend { get; set; }

    public string? ReverseDescr { get; set; }

    public string? ReverseLegend { get; set; }

    public string? SubjectObverse { get; set; }

    public string? SubjectReverse { get; set; }

    public string? Exergue { get; set; }

    public string? Mint { get; set; }

    public string? Nominal { get; set; }

    public string? Emperor { get; set; }

    public string? IssuingAuthority { get; set; }

    public string? ChronMin { get; set; }

    public string? ChronMax { get; set; }

    public string? Provenance { get; set; }

    public string? StateCons { get; set; }

    public string? ConsPlace { get; set; }

    public string? Ref { get; set; }

    public string? Notes { get; set; }

    public bool? DatingElement { get; set; }

    public long? WrittenSourcesObjectId { get; set; }

    public long? IconographicSourceId { get; set; }

    public long? GeneralBibliographyId { get; set; }

    public long? PhotographicSourceId { get; set; }

    public long? PhotographId { get; set; }

    public long? ArchivalSourceId { get; set; }

    public long? ArchivalDrawingId { get; set; }

    public long? DrawingId { get; set; }

    public DateOnly? ExcStartDate { get; set; }

    public DateOnly? ExcEndDate { get; set; }

    public string? ReasonsExcStart { get; set; }

    public string? ReasonsExcEnd { get; set; }

    public string? Director { get; set; }

    public string? SheetAuthor { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ArchivalDrawing? ArchivalDrawing { get; set; }

    public virtual ArchivalSource? ArchivalSource { get; set; }

    public virtual Area? Area { get; set; }

    public virtual Drawing? Drawing { get; set; }

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
