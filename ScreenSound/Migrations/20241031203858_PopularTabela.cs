using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    public partial class PopularTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] {"Nome", "Bio", "FotoPerfil"}, 
	            new object[]
	            {
		            "Djavan", "Cantor, ex-jogador e de Aracaju.",
		            "https://djavan.com.br/content/uploads/2018/11/djavan-1982_4861158618_o-400x0-c-default.jpg"
	            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" },
	            new object[]
	            {
		            "Marisa Monte", "Perfeita, nunca errou.",
					"https://akamai.sscdn.co/uploadfile/letras/fotos/f/7/b/a/f7bae22807ab335f4a21677ef8e5c18f.jpg"
				});

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" },
	            new object[]
	            {
		            "Gilberto Gil", "Fundou a Bahia junto com Caetano Veloso.",
					"https://yt3.googleusercontent.com/WZOmwdSbVIoGEojY_y6fCdC26NMIcBqZ0DLqr6J_MQDWYnBFRE2HKCf5ufqQfnUTjd7anNhKgQ=s900-c-k-c0x00ffffff-no-rj"
				});

		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
