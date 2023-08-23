using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class Facture
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public DateTime? DateFacture { get; set; }

    public DateTime? DateEcheance { get; set; }

    public double? Remise { get; set; }

    public double? Montant { get; set; }

    public bool? Payed { get; set; }

    public DateTime? PayingDate { get; set; }

    public virtual ICollection<DetailFacture> DetailFactures { get; set; } = new List<DetailFacture>();
}
