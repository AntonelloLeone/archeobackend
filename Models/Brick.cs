using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Brick
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public long? SpecialFindId { get; set; }

    public string? BrickClass { get; set; }

    public long? BricksFormId { get; set; }

    public string? BrickType { get; set; }

    public long? BricksClayId { get; set; }

    public string? ClayColor { get; set; }

    public long? BricksInstallationId { get; set; }

    public long? BricksWorkingId { get; set; }

    public long? BricksConsistenceId { get; set; }

    public string? Refiniment { get; set; }

    public string? Baking { get; set; }

    public string? CookingLevel { get; set; }

    public string? Integrity { get; set; }

    public decimal? HeightCm { get; set; }

    public decimal? WidthCm { get; set; }

    public decimal? ThicknessCm { get; set; }

    public decimal? WeightG { get; set; }

    public bool? Stamp { get; set; }

    public string? StampIntegrity { get; set; }

    public string? StampLegibility { get; set; }

    public string? ImpressionQuality { get; set; }

    public string? PunchMaterial { get; set; }

    public string? PunchQuality { get; set; }

    public string? ScrollForm { get; set; }

    public string? ScrollMeasures { get; set; }

    public string? Decorations { get; set; }

    public string? DescrEpi { get; set; }

    public bool? Epigraphics { get; set; }

    public long? EpigraphicElementId { get; set; }

    public string? FiglineWorkshop { get; set; }

    public string? DominusAPrediorum { get; set; }

    public string? Officinator { get; set; }

    public string? Worker { get; set; }

    public string? Provenance { get; set; }

    public long? ZoneId { get; set; }

    public long? RoomId { get; set; }

    public long? TrenchId { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public bool? DatingElement { get; set; }

    public string? ConsPlace { get; set; }

    public string? Ref { get; set; }

    public long? IconographicSourceId { get; set; }

    public long? GeneralBibliographyId { get; set; }

    public long? PhotographicSourceId { get; set; }

    public long? PhotographId { get; set; }

    public long? ArchivalSourceId { get; set; }

    public long? ArchivalDrawingId { get; set; }

    public long? DrawingId { get; set; }

    public long? WrittenSourcesObjectId { get; set; }

    public string? SheetAuthor { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ArchivalDrawing? ArchivalDrawing { get; set; }

    public virtual ArchivalSource? ArchivalSource { get; set; }

    public virtual BricksClay? BricksClay { get; set; }

    public virtual BricksConsistence? BricksConsistence { get; set; }

    public virtual BricksForm? BricksForm { get; set; }

    public virtual BricksInstallation? BricksInstallation { get; set; }

    public virtual BricksWorking? BricksWorking { get; set; }

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
