using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    public partial class PopularTabelaMusica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Oceano", "1989" });
	        migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Samurai", "1982" });
	        migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Azul", "2005" });
	        migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Lilás", "1984" });
	        migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Vilarejo", "2006" });
			migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Beija eu", "1991" });
	        migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Maria de verdade", "1994" });
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("DELETE FROM Musicas");
		}
    }
}
