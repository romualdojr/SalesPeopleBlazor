using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesPeople.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "A Série da Fundação é uma obra de ficção científica escrita por Isaac Asimov que descreve em detalhes a história de um futuro distante e de como o destino de seus habitantes é influenciado por uma instituição chamada Fundação Enciclopédica", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Fundacaobox_frente_alta.jpg/800px-Fundacaobox_frente_alta.jpg", 9.99m, "Série da Fundação" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Os Contos de Beedle, o Bardo é um livro de histórias infantis escrito pela autora J. K. Rowling. Ele é o mesmo livro de contos mencionado em Harry Potter e as Relíquias da Morte, o último livro da série Harry Potter.[2]", "https://upload.wikimedia.org/wikipedia/pt/c/c8/Os_Contos_de_Beedle_o_Bardo.jpg", 5.99m, "Os Contos de Beedle, o Bardo" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "O Necronomicon (O Necronomicon é um livro fictício criado por H.P.Lovecraft, autor americano de ficção científica, horror e literatura fantástica. Segundo o próprio, o Necronomicon teria sido escrito em Damasco por volta de 730 d.C. por Abdul Alhazred, um poeta árabe louco originário de Sanaa, no Iémen.", "https://upload.wikimedia.org/wikipedia/commons/0/0c/Necronomicon_prop.jpg", 6.66m, "Necronomicon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
