using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotCrypto.ColetaInformacao.Data.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataModificacao = table.Column<DateTime>(nullable: false),
                    TipoMoeda = table.Column<int>(nullable: false),
                    buy = table.Column<double>(nullable: false),
                    sell = table.Column<double>(nullable: false),
                    high = table.Column<double>(nullable: false),
                    low = table.Column<double>(nullable: false),
                    vol = table.Column<double>(nullable: false),
                    last = table.Column<double>(nullable: false),
                    date = table.Column<int>(nullable: false),
                    DateNormal = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickers");
        }
    }
}
