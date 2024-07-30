using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class LocusWall
{
    public long Id { get; set; }

    public string? UsNum { get; set; }

    public int? ExcYear { get; set; }

    public long? TrenchId { get; set; }

    public long? ZoneId { get; set; }

    public long? RoomId { get; set; }

    public string? UsLocation { get; set; }

    public int? Emin { get; set; }

    public int? Emax { get; set; }

    public string? Definition { get; set; }

    public string? DistCriteria { get; set; }

    public string? Preservation { get; set; }

    public string? Bricks { get; set; }

    public long? BricksWorkingId { get; set; }

    public long? BricksConsistenceId { get; set; }

    public long? BricksFormId { get; set; }

    public string? BricksColor { get; set; }

    public long? BricksClayId { get; set; }

    public long? BricksInstallationId { get; set; }

    public string? Stone { get; set; }

    public long? StoneWorkingId { get; set; }

    public long? StoneFormId { get; set; }

    public long? StoneCuttingId { get; set; }

    public long? StoneInstallationId { get; set; }

    public string? Binder { get; set; }

    public string? BinderType { get; set; }

    public string? BinderConsistency { get; set; }

    public string? BinderColor { get; set; }

    public string? Aggregates { get; set; }

    public int? ThicknessCm { get; set; }

    public string? Finishing { get; set; }

    public string? SameAs { get; set; }

    public string? AbuttedBy { get; set; }

    public string? CoveredBy { get; set; }

    public string? CutBy { get; set; }

    public string? FilledBy { get; set; }

    public string? BindsWith { get; set; }

    public string? Abuts { get; set; }

    public string? Covers { get; set; }

    public string? Cuts { get; set; }

    public string? Fills { get; set; }

    public int? Later { get; set; }

    public int? PriorTo { get; set; }

    public string? Description { get; set; }

    public string? Interpretation { get; set; }

    public string? Observation { get; set; }

    public int? CronMin { get; set; }

    public int? CronMax { get; set; }

    public string? PeriodStart { get; set; }

    public string? PeriodEnd { get; set; }

    public string? Phase { get; set; }

    public string? Activity { get; set; }

    public bool? Sampling { get; set; }

    public string? Dependability { get; set; }

    public string? Director { get; set; }

    public string? SheetAuthor { get; set; }

    public string? DateComp { get; set; }

    public string? IdPh { get; set; }

    public string? IdPhs { get; set; }

    public string? IdDw { get; set; }

    public string? IdAdw { get; set; }

    public long? DrawTypeId { get; set; }

    public string? ImagePh { get; set; }

    public string? ImageDw { get; set; }

    public string? IdBiblio { get; set; }

    public string? IdIco { get; set; }

    public string? IdAs { get; set; }

    public string? IdWs { get; set; }

    public string? IdWse { get; set; }

    public string? IdIe { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? QMinStart { get; set; }

    public string? QMaxStart { get; set; }

    public string? QMinEnd { get; set; }

    public string? QMaxEnd { get; set; }

    public DateOnly? StartExcavationsUs { get; set; }

    public string? StartExcavationsUsReason { get; set; }

    public string? EndExcavationsUsReason { get; set; }

    public long? MaterialProvenanceId { get; set; }

    public long? AreaId { get; set; }

    public virtual Area? Area { get; set; }

    public virtual BricksClay? BricksClay { get; set; }

    public virtual BricksConsistence? BricksConsistence { get; set; }

    public virtual BricksForm? BricksForm { get; set; }

    public virtual BricksInstallation? BricksInstallation { get; set; }

    public virtual BricksWorking? BricksWorking { get; set; }

    public virtual DrawType? DrawType { get; set; }

    public virtual MaterialProvenance? MaterialProvenance { get; set; }

    public virtual Room? Room { get; set; }

    public virtual StoneCutting? StoneCutting { get; set; }

    public virtual StoneForm? StoneForm { get; set; }

    public virtual StoneInstallation? StoneInstallation { get; set; }

    public virtual StoneWorking? StoneWorking { get; set; }

    public virtual Trench? Trench { get; set; }

    public virtual Zone? Zone { get; set; }
}
