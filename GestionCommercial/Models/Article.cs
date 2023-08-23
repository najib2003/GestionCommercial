using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class Article
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Label { get; set; }

    public int? IdFamille { get; set; }

    public virtual ICollection<DetailBe> DetailBes { get; set; } = new List<DetailBe>();

    public virtual ICollection<DetailB> DetailBs { get; set; } = new List<DetailB>();

    public virtual FamilleArticle? IdFamilleNavigation { get; set; }
}
