using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaProject.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PizzaList",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { 1, "Большая пицца Барбекю, 35см, 630г.", "Пицца Барбекю", "/img/1.jpeg", 750m },
                    { 2, "Большая пицца Сырная, 35см, 540г.", "Пицца Сырная", "/img/2.jpeg", 410m },
                    { 3, "Большая пицца Пеперони, 35см, 570г.", "Пицца Пеперони", "/img/3.jpeg", 500m },
                    { 4, "Большая пицца Ветчина и сыр, 35см, 570г.", "Пицца Ветчина и сыр", "/img/4.jpeg", 500m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaList");
        }
    }
}
