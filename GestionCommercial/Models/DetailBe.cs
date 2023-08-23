using System;
using System.Collections.Generic;

namespace GestionCommercial.Models;

public partial class DetailBe
{
    public int Id { get; set; }

    public int? IdBe { get; set; }

    public int? IdArticle { get; set; }

    public double? Qte { get; set; }

    public double? Prix { get; set; }

    public double? Montant { get; set; }

    public virtual Article? IdArticleNavigation { get; set; }

    public virtual BonEntree IdNavigation { get; set; } = null!;
}
