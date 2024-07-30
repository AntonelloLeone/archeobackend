using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BiblioLink
{
    public long Id { get; set; }

    public long GeneralBibliographyId { get; set; }

    public long? TrenchId { get; set; }

    public long? IntangibleElementId { get; set; }

    public long? IconographicSourceId { get; set; }

    public long? LocusListId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual GeneralBibliography GeneralBibliography { get; set; } = null!;

    public virtual IconographicSource? IconographicSource { get; set; }

    public virtual IntangibleElement? IntangibleElement { get; set; }

    public virtual LocusList? LocusList { get; set; }

    public virtual Trench? Trench { get; set; }
}
