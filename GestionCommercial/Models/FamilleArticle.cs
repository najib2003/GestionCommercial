using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class FamilleArticle
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Label { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
