using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionCommercial.Models;

public partial class GestionCommercialeContext : DbContext
{
    public GestionCommercialeContext()
    {
    }

    public GestionCommercialeContext(DbContextOptions<GestionCommercialeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<BonEntree> BonEntrees { get; set; }

    public virtual DbSet<BonSortie> BonSorties { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DetailB> DetailBs { get; set; }

    public virtual DbSet<DetailBe> DetailBes { get; set; }

    public virtual DbSet<DetailFacture> DetailFactures { get; set; }

    public virtual DbSet<Facture> Factures { get; set; }

    public virtual DbSet<FamilleArticle> FamilleArticles { get; set; }

    public virtual DbSet<Fournisseur> Fournisseurs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=STAN\\SQLEXPRESS; Database=GestionCommerciale;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.ToTable("Article");

            entity.HasIndex(e => e.Code, "IX_Article").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.IdFamille).HasColumnName("idFamille");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .HasColumnName("label");

            entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.Articles)
                .HasForeignKey(d => d.IdFamille)
                .HasConstraintName("FK_Article_FamilleArticle");
        });

        modelBuilder.Entity<BonEntree>(entity =>
        {
            entity.ToTable("BonEntree");

            entity.HasIndex(e => e.Code, "IX_BonEntree").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.IdFournisseur).HasColumnName("idFournisseur");
            entity.Property(e => e.Montant).HasColumnName("montant");

            entity.HasOne(d => d.IdFournisseurNavigation).WithMany(p => p.BonEntrees)
                .HasForeignKey(d => d.IdFournisseur)
                .HasConstraintName("FK_BonEntree_Fournisseur");
        });

        modelBuilder.Entity<BonSortie>(entity =>
        {
            entity.ToTable("BonSortie");

            entity.HasIndex(e => e.Code, "IX_BonSortie").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.IdClient).HasColumnName("idClient");
            entity.Property(e => e.Montant).HasColumnName("montant");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.BonSorties)
                .HasForeignKey(d => d.IdClient)
                .HasConstraintName("FK_BonSortie_Client");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CodePostale)
                .HasMaxLength(50)
                .HasColumnName("codePostale");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(50)
                .HasColumnName("raisonSociale");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("tel");
            entity.Property(e => e.Ville)
                .HasMaxLength(50)
                .HasColumnName("ville");
        });

        modelBuilder.Entity<DetailB>(entity =>
        {
            entity.ToTable("DetailBS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdArticle).HasColumnName("idArticle");
            entity.Property(e => e.IdBs).HasColumnName("idBS");
            entity.Property(e => e.Montant).HasColumnName("montant");
            entity.Property(e => e.Prix).HasColumnName("prix");
            entity.Property(e => e.Qte).HasColumnName("qte");

            entity.HasOne(d => d.IdArticleNavigation).WithMany(p => p.DetailBs)
                .HasForeignKey(d => d.IdArticle)
                .HasConstraintName("FK_DetailBS_Article");

            entity.HasOne(d => d.IdBsNavigation).WithMany(p => p.DetailBs)
                .HasForeignKey(d => d.IdBs)
                .HasConstraintName("FK_DetailBS_BonSortie");
        });

        modelBuilder.Entity<DetailBe>(entity =>
        {
            entity.ToTable("DetailBE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdArticle).HasColumnName("idArticle");
            entity.Property(e => e.IdBe).HasColumnName("idBE");
            entity.Property(e => e.Montant).HasColumnName("montant");
            entity.Property(e => e.Prix).HasColumnName("prix");
            entity.Property(e => e.Qte).HasColumnName("qte");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.DetailBe)
                .HasForeignKey<DetailBe>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailBE_BonEntree");

            entity.HasOne(d => d.IdArticleNavigation).WithMany(p => p.DetailBes)
                .HasForeignKey(d => d.IdArticle)
                .HasConstraintName("FK_DetailBE_Article");
        });

        modelBuilder.Entity<DetailFacture>(entity =>
        {
            entity.ToTable("DetailFacture");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdBs).HasColumnName("idBS");
            entity.Property(e => e.IdFacture).HasColumnName("idFacture");
            entity.Property(e => e.Montant).HasColumnName("montant");

            entity.HasOne(d => d.IdFactureNavigation).WithMany(p => p.DetailFactures)
                .HasForeignKey(d => d.IdFacture)
                .HasConstraintName("FK_DetailFacture_BonSortie");

            entity.HasOne(d => d.IdFacture1).WithMany(p => p.DetailFactures)
                .HasForeignKey(d => d.IdFacture)
                .HasConstraintName("FK_DetailFacture_Facture");
        });

        modelBuilder.Entity<Facture>(entity =>
        {
            entity.ToTable("Facture");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.DateEcheance)
                .HasColumnType("date")
                .HasColumnName("dateEcheance");
            entity.Property(e => e.DateFacture)
                .HasColumnType("date")
                .HasColumnName("dateFacture");
            entity.Property(e => e.Montant).HasColumnName("montant");
            entity.Property(e => e.Payed).HasColumnName("payed");
            entity.Property(e => e.PayingDate)
                .HasColumnType("date")
                .HasColumnName("payingDate");
            entity.Property(e => e.Remise).HasColumnName("remise");
        });

        modelBuilder.Entity<FamilleArticle>(entity =>
        {
            entity.ToTable("FamilleArticle");

            entity.HasIndex(e => e.Code, "IX_FamilleArticle");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Fournisseur>(entity =>
        {
            entity.ToTable("Fournisseur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CodePostale)
                .HasMaxLength(50)
                .HasColumnName("codePostale");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(50)
                .HasColumnName("raisonSociale");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("tel");
            entity.Property(e => e.Ville)
                .HasMaxLength(50)
                .HasColumnName("ville");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("User");

            entity.Property(e => e.IdUser).HasMaxLength(50);
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Prenom).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
