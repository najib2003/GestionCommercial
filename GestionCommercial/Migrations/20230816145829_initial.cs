using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionCommercial.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raisonSociale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    codePostale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dateFacture = table.Column<DateTime>(type: "date", nullable: true),
                    dateEcheance = table.Column<DateTime>(type: "date", nullable: true),
                    remise = table.Column<double>(type: "float", nullable: true),
                    montant = table.Column<double>(type: "float", nullable: true),
                    payed = table.Column<bool>(type: "bit", nullable: true),
                    payingDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FamilleArticle",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilleArticle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raisonSociale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    codePostale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "BonSortie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: true),
                    idClient = table.Column<int>(type: "int", nullable: true),
                    montant = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonSortie", x => x.id);
                    table.ForeignKey(
                        name: "FK_BonSortie_Client",
                        column: x => x.idClient,
                        principalTable: "Client",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    label = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    idFamille = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.id);
                    table.ForeignKey(
                        name: "FK_Article_FamilleArticle",
                        column: x => x.idFamille,
                        principalTable: "FamilleArticle",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "BonEntree",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    date = table.Column<DateTime>(type: "date", nullable: true),
                    idFournisseur = table.Column<int>(type: "int", nullable: true),
                    montant = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonEntree", x => x.id);
                    table.ForeignKey(
                        name: "FK_BonEntree_Fournisseur",
                        column: x => x.idFournisseur,
                        principalTable: "Fournisseur",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DetailFacture",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idFacture = table.Column<int>(type: "int", nullable: true),
                    idBS = table.Column<int>(type: "int", nullable: true),
                    montant = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailFacture", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetailFacture_BonSortie",
                        column: x => x.idFacture,
                        principalTable: "BonSortie",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_DetailFacture_Facture",
                        column: x => x.idFacture,
                        principalTable: "Facture",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DetailBS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idBS = table.Column<int>(type: "int", nullable: true),
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    qte = table.Column<double>(type: "float", nullable: true),
                    prix = table.Column<double>(type: "float", nullable: true),
                    montant = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailBS", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetailBS_Article",
                        column: x => x.idArticle,
                        principalTable: "Article",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_DetailBS_BonSortie",
                        column: x => x.idBS,
                        principalTable: "BonSortie",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DetailBE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    idBE = table.Column<int>(type: "int", nullable: true),
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    qte = table.Column<double>(type: "float", nullable: true),
                    prix = table.Column<double>(type: "float", nullable: true),
                    montant = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailBE", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetailBE_Article",
                        column: x => x.idArticle,
                        principalTable: "Article",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_DetailBE_BonEntree",
                        column: x => x.id,
                        principalTable: "BonEntree",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article",
                table: "Article",
                column: "code",
                unique: true,
                filter: "[code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Article_idFamille",
                table: "Article",
                column: "idFamille");

            migrationBuilder.CreateIndex(
                name: "IX_BonEntree",
                table: "BonEntree",
                column: "code",
                unique: true,
                filter: "[code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BonEntree_idFournisseur",
                table: "BonEntree",
                column: "idFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_BonSortie",
                table: "BonSortie",
                column: "code",
                unique: true,
                filter: "[code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BonSortie_idClient",
                table: "BonSortie",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_DetailBE_idArticle",
                table: "DetailBE",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_DetailBS_idArticle",
                table: "DetailBS",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_DetailBS_idBS",
                table: "DetailBS",
                column: "idBS");

            migrationBuilder.CreateIndex(
                name: "IX_DetailFacture_idFacture",
                table: "DetailFacture",
                column: "idFacture");

            migrationBuilder.CreateIndex(
                name: "IX_FamilleArticle",
                table: "FamilleArticle",
                column: "code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailBE");

            migrationBuilder.DropTable(
                name: "DetailBS");

            migrationBuilder.DropTable(
                name: "DetailFacture");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "BonEntree");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "BonSortie");

            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "FamilleArticle");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
