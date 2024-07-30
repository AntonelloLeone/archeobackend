using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Locu
{
    public long Id { get; set; }

    public string? Tsdbcode { get; set; }

    public string? ExcYear { get; set; }

    public long? TrenchId { get; set; }

    public long? ZoneId { get; set; }

    public string? UsLocation { get; set; }

    public int? Emin { get; set; }

    public int? Emax { get; set; }

    public string? Definition { get; set; }

    public string? DistCriteria { get; set; }

    public long? LocusFormationId { get; set; }

    public string? Consistency { get; set; }

    public string? Color { get; set; }

    public string? Measures { get; set; }

    public string? Preservation { get; set; }

    public string? CompOrg { get; set; }

    public string? CompGeo { get; set; }

    public string? CompArt { get; set; }

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

    public string? Observations { get; set; }

    public string? CronMin { get; set; }

    public string? CronMax { get; set; }

    public string? Period { get; set; }

    public string? Phase { get; set; }

    public string? Activity { get; set; }

    public bool? Sampling { get; set; }

    public string? Dependability { get; set; }

    public string? Director { get; set; }

    public string? SheetAuthor { get; set; }

    public string? DateComp { get; set; }

    public string? IdPhs { get; set; }

    public string? IdAdw { get; set; }

    public long? DrawTypeId { get; set; }

    public string? ImagePh { get; set; }

    public string? ImageDw { get; set; }

    public string? IdBiblio { get; set; }

    public string? DrawType1 { get; set; }

    public string? ImagePh1 { get; set; }

    public string? ImageDw1 { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? QMinStart { get; set; }

    public string? QMaxStart { get; set; }

    public string? QMinEnd { get; set; }

    public string? QMaxEnd { get; set; }

    public DateOnly? StartExcavationsUs { get; set; }

    public string? StartExcavationsUsReason { get; set; }

    public string? EndExcavationsUsReason { get; set; }

    public long? AreaId { get; set; }

    public virtual Area? Area { get; set; }

    public virtual DrawType? DrawType { get; set; }

    public virtual LocusFormation? LocusFormation { get; set; }

    public virtual Trench? Trench { get; set; }

    public virtual Zone? Zone { get; set; }
}
