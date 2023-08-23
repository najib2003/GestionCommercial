using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class BonEntree
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public DateTime? Date { get; set; }

    public int? IdFournisseur { get; set; }

    public double? Montant { get; set; }

    public virtual DetailBe? DetailBe { get; set; }

    public virtual Fournisseur? IdFournisseurNavigation { get; set; }
}
