using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class Client
{
    public int Id { get; set; }

    public string? RaisonSociale { get; set; }

    public string? Email { get; set; }

    public string? Tel { get; set; }

    public string? Ville { get; set; }

    public string? CodePostale { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<BonSortie> BonSorties { get; set; } = new List<BonSortie>();
}
