﻿// <auto-generated />
using System;
using GestionCommercial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionCommercial.Migrations
{
    [DbContext(typeof(GestionCommercialeContext))]
    partial class GestionCommercialeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionCommercial.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("code");

                    b.Property<int?>("IdFamille")
                        .HasColumnType("int")
                        .HasColumnName("idFamille");

                    b.Property<string>("Label")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("label");

                    b.HasKey("Id");

                    b.HasIndex("IdFamille");

                    b.HasIndex(new[] { "Code" }, "IX_Article")
                        .IsUnique()
                        .HasFilter("[code] IS NOT NULL");

                    b.ToTable("Article", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.BonEntree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("code");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<int?>("IdFournisseur")
                        .HasColumnType("int")
                        .HasColumnName("idFournisseur");

                    b.Property<double?>("Montant")
                        .HasColumnType("float")
                        .HasColumnName("montant");

                    b.HasKey("Id");

                    b.HasIndex("IdFournisseur");

                    b.HasIndex(new[] { "Code" }, "IX_BonEntree")
                        .IsUnique()
                        .HasFilter("[code] IS NOT NULL");

                    b.ToTable("BonEntree", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.BonSortie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("code");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<int?>("IdClient")
                        .HasColumnType("int")
                        .HasColumnName("idClient");

                    b.Property<double?>("Montant")
                        .HasColumnType("float")
                        .HasColumnName("montant");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.HasIndex(new[] { "Code" }, "IX_BonSortie")
                        .IsUnique()
                        .HasFilter("[code] IS NOT NULL");

                    b.ToTable("BonSortie", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("active");

                    b.Property<string>("CodePostale")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codePostale");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("RaisonSociale")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("raisonSociale");

                    b.Property<string>("Tel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tel");

                    b.Property<string>("Ville")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ville");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.DetailB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdArticle")
                        .HasColumnType("int")
                        .HasColumnName("idArticle");

                    b.Property<int?>("IdBs")
                        .HasColumnType("int")
                        .HasColumnName("idBS");

                    b.Property<double?>("Montant")
                        .HasColumnType("float")
                        .HasColumnName("montant");

                    b.Property<double?>("Prix")
                        .HasColumnType("float")
                        .HasColumnName("prix");

                    b.Property<double?>("Qte")
                        .HasColumnType("float")
                        .HasColumnName("qte");

                    b.HasKey("Id");

                    b.HasIndex("IdArticle");

                    b.HasIndex("IdBs");

                    b.ToTable("DetailBS", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.DetailBe", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("IdArticle")
                        .HasColumnType("int")
                        .HasColumnName("idArticle");

                    b.Property<int?>("IdBe")
                        .HasColumnType("int")
                        .HasColumnName("idBE");

                    b.Property<double?>("Montant")
                        .HasColumnType("float")
                        .HasColumnName("montant");

                    b.Property<double?>("Prix")
                        .HasColumnType("float")
                        .HasColumnName("prix");

                    b.Property<double?>("Qte")
                        .HasColumnType("float")
                        .HasColumnName("qte");

                    b.HasKey("Id");

                    b.HasIndex("IdArticle");

                    b.ToTable("DetailBE", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.DetailFacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdBs")
                        .HasColumnType("int")
                        .HasColumnName("idBS");

                    b.Property<int?>("IdFacture")
                        .HasColumnType("int")
                        .HasColumnName("idFacture");

                    b.Property<double?>("Montant")
                        .HasColumnType("float")
                        .HasColumnName("montant");

                    b.HasKey("Id");

                    b.HasIndex("IdFacture");

                    b.ToTable("DetailFacture", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.Facture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("code");

                    b.Property<DateTime?>("DateEcheance")
                        .HasColumnType("date")
                        .HasColumnName("dateEcheance");

                    b.Property<DateTime?>("DateFacture")
                        .HasColumnType("date")
                        .HasColumnName("dateFacture");

                    b.Property<double?>("Montant")
                        .HasColumnType("float")
                        .HasColumnName("montant");

                    b.Property<bool?>("Payed")
                        .HasColumnType("bit")
                        .HasColumnName("payed");

                    b.Property<DateTime?>("PayingDate")
                        .HasColumnType("date")
                        .HasColumnName("payingDate");

                    b.Property<double?>("Remise")
                        .HasColumnType("float")
                        .HasColumnName("remise");

                    b.HasKey("Id");

                    b.ToTable("Facture", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.FamilleArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("code");

                    b.Property<string>("Label")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("label");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Code" }, "IX_FamilleArticle");

                    b.ToTable("FamilleArticle", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.Fournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("active");

                    b.Property<string>("CodePostale")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("codePostale");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("RaisonSociale")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("raisonSociale");

                    b.Property<string>("Tel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tel");

                    b.Property<string>("Ville")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ville");

                    b.HasKey("Id");

                    b.ToTable("Fournisseur", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.User", b =>
                {
                    b.Property<string>("IdUser")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUser");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("GestionCommercial.Models.Article", b =>
                {
                    b.HasOne("GestionCommercial.Models.FamilleArticle", "IdFamilleNavigation")
                        .WithMany("Articles")
                        .HasForeignKey("IdFamille")
                        .HasConstraintName("FK_Article_FamilleArticle");

                    b.Navigation("IdFamilleNavigation");
                });

            modelBuilder.Entity("GestionCommercial.Models.BonEntree", b =>
                {
                    b.HasOne("GestionCommercial.Models.Fournisseur", "IdFournisseurNavigation")
                        .WithMany("BonEntrees")
                        .HasForeignKey("IdFournisseur")
                        .HasConstraintName("FK_BonEntree_Fournisseur");

                    b.Navigation("IdFournisseurNavigation");
                });

            modelBuilder.Entity("GestionCommercial.Models.BonSortie", b =>
                {
                    b.HasOne("GestionCommercial.Models.Client", "IdClientNavigation")
                        .WithMany("BonSorties")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("FK_BonSortie_Client");

                    b.Navigation("IdClientNavigation");
                });

            modelBuilder.Entity("GestionCommercial.Models.DetailB", b =>
                {
                    b.HasOne("GestionCommercial.Models.Article", "IdArticleNavigation")
                        .WithMany("DetailBs")
                        .HasForeignKey("IdArticle")
                        .HasConstraintName("FK_DetailBS_Article");

                    b.HasOne("GestionCommercial.Models.BonSortie", "IdBsNavigation")
                        .WithMany("DetailBs")
                        .HasForeignKey("IdBs")
                        .HasConstraintName("FK_DetailBS_BonSortie");

                    b.Navigation("IdArticleNavigation");

                    b.Navigation("IdBsNavigation");
                });

            modelBuilder.Entity("GestionCommercial.Models.DetailBe", b =>
                {
                    b.HasOne("GestionCommercial.Models.BonEntree", "IdNavigation")
                        .WithOne("DetailBe")
                        .HasForeignKey("GestionCommercial.Models.DetailBe", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_DetailBE_BonEntree");

                    b.HasOne("GestionCommercial.Models.Article", "IdArticleNavigation")
                        .WithMany("DetailBes")
                        .HasForeignKey("IdArticle")
                        .HasConstraintName("FK_DetailBE_Article");

                    b.Navigation("IdArticleNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("GestionCommercial.Models.DetailFacture", b =>
                {
                    b.HasOne("GestionCommercial.Models.BonSortie", "IdFactureNavigation")
                        .WithMany("DetailFactures")
                        .HasForeignKey("IdFacture")
                        .HasConstraintName("FK_DetailFacture_BonSortie");

                    b.HasOne("GestionCommercial.Models.Facture", "IdFacture1")
                        .WithMany("DetailFactures")
                        .HasForeignKey("IdFacture")
                        .HasConstraintName("FK_DetailFacture_Facture");

                    b.Navigation("IdFacture1");

                    b.Navigation("IdFactureNavigation");
                });

            modelBuilder.Entity("GestionCommercial.Models.Article", b =>
                {
                    b.Navigation("DetailBes");

                    b.Navigation("DetailBs");
                });

            modelBuilder.Entity("GestionCommercial.Models.BonEntree", b =>
                {
                    b.Navigation("DetailBe");
                });

            modelBuilder.Entity("GestionCommercial.Models.BonSortie", b =>
                {
                    b.Navigation("DetailBs");

                    b.Navigation("DetailFactures");
                });

            modelBuilder.Entity("GestionCommercial.Models.Client", b =>
                {
                    b.Navigation("BonSorties");
                });

            modelBuilder.Entity("GestionCommercial.Models.Facture", b =>
                {
                    b.Navigation("DetailFactures");
                });

            modelBuilder.Entity("GestionCommercial.Models.FamilleArticle", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("GestionCommercial.Models.Fournisseur", b =>
                {
                    b.Navigation("BonEntrees");
                });
#pragma warning restore 612, 618
        }
    }
}