using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class BonSortie
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public DateTime? Date { get; set; }

    public int? IdClient { get; set; }

    public double? Montant { get; set; }

    public virtual ICollection<DetailB> DetailBs { get; set; } = new List<DetailB>();

    public virtual ICollection<DetailFacture> DetailFactures { get; set; } = new List<DetailFacture>();

    public virtual Client? IdClientNavigation { get; set; }
}
