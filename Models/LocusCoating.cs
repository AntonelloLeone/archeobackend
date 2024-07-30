using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class LocusCoating
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

    public string? CoatingTechnique { get; set; }

    public string? Materials { get; set; }

    public string? SameAs { get; set; }

    public string? AbuttedBy { get; set; }

    public string? CoveredBy { get; set; }

    public string? BindsWith { get; set; }

    public string? Abuts { get; set; }

    public string? Covers { get; set; }

    public int? Later { get; set; }

    public int? PriorTo { get; set; }

    public string? Layer1 { get; set; }

    public string? Layer2 { get; set; }

    public string? Layer3 { get; set; }

    public string? Layer4 { get; set; }

    public string? Tickhess1 { get; set; }

    public string? Tickhess2 { get; set; }

    public string? Tickhess3 { get; set; }

    public string? Tickhess4 { get; set; }

    public string? Color1 { get; set; }

    public string? Color2 { get; set; }

    public string? Color3 { get; set; }

    public string? Color4 { get; set; }

    public string? CompInorg1 { get; set; }

    public string? CompInorg2 { get; set; }

    public string? CompInorg3 { get; set; }

    public string? CompInorg4 { get; set; }

    public string? CompOrg1 { get; set; }

    public string? CompOrg2 { get; set; }

    public string? CompOrg3 { get; set; }

    public string? CompOrg4 { get; set; }

    public string? Sinopia1 { get; set; }

    public string? Sinopia2 { get; set; }

    public string? Sinopia3 { get; set; }

    public string? Sinopia4 { get; set; }

    public string? CordBeat1 { get; set; }

    public string? CordBeat2 { get; set; }

    public string? CordBeat3 { get; set; }

    public string? CordBeat4 { get; set; }

    public string? Graffito1 { get; set; }

    public string? Graffito2 { get; set; }

    public string? Graffito3 { get; set; }

    public string? Graffito4 { get; set; }

    public string? BackPrints1 { get; set; }

    public string? BackPrints2 { get; set; }

    public string? BackPrints3 { get; set; }

    public string? BackPrints4 { get; set; }

    public string? Surface { get; set; }

    public string? SurfaceColors { get; set; }

    public string? OverlaysColors { get; set; }

    public string? Observations { get; set; }

    public string? Description { get; set; }

    public string? EpigraphicDate { get; set; }

    public string? CornerProfile { get; set; }

    public bool? Trama { get; set; }

    public string? TramaMaterials { get; set; }

    public string? Form { get; set; }

    public string? Measures { get; set; }

    public string? N100Cmq { get; set; }

    public string? Warp { get; set; }

    public string? StuctureRel { get; set; }

    public string? DatingElements { get; set; }

    public int? ChronMin { get; set; }

    public int? ChronMax { get; set; }

    public string? StylisticPhase { get; set; }

    public string? PeriodStart { get; set; }

    public string? PeriodEnd { get; set; }

    public string? Phase { get; set; }

    public string? Ref { get; set; }

    public string? SurfaceDeposits { get; set; }

    public string? Incrustations { get; set; }

    public string? DefectsInAdesion { get; set; }

    public string? DefectsInCohesion { get; set; }

    public string? Gaps { get; set; }

    public string? Usury { get; set; }

    public string? Other { get; set; }

    public string? Consolidation { get; set; }

    public string? Gluing { get; set; }

    public string? Glazing { get; set; }

    public string? Detachment { get; set; }

    public string? Packaging { get; set; }

    public string? TemporaryCovering { get; set; }

    public string? SamplyngToAnalysis { get; set; }

    public string? LabAddress { get; set; }

    public string? Director { get; set; }

    public string? SheetAuthor { get; set; }

    public DateOnly? DateComp { get; set; }

    public string? IdPh { get; set; }

    public string? IdPhs { get; set; }

    public string? IdDw { get; set; }

    public string? IdAdw { get; set; }

    public long? DrawTypeId { get; set; }

    public string? IdBiblio { get; set; }

    public string? IdIco { get; set; }

    public string? IdAs { get; set; }

    public string? IdWs { get; set; }

    public string? IdExtract { get; set; }

    public string? IdIe { get; set; }

    public string? Dependability { get; set; }

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

    public virtual Room? Room { get; set; }

    public virtual Trench? Trench { get; set; }

    public virtual Zone? Zone { get; set; }
}
