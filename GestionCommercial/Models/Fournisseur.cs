using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class Fournisseur
{
    public int Id { get; set; }

    public string? RaisonSociale { get; set; }

    public string? Email { get; set; }

    public string? Tel { get; set; }

    public string? Ville { get; set; }

    public string? CodePostale { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<BonEntree> BonEntrees { get; set; } = new List<BonEntree>();
}
