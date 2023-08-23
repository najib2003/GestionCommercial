using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class DetailFacture
{
    public int Id { get; set; }

    public int? IdFacture { get; set; }

    public int? IdBs { get; set; }

    public double? Montant { get; set; }

    public virtual Facture? IdFacture1 { get; set; }

    public virtual BonSortie? IdFactureNavigation { get; set; }
}
